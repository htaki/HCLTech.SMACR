using HCLTech.SMACR.EmissionFactors;
using HCLTech.SMACR.Users;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace HCLTech.SMACR.EnergyReductionPlans;

public class EnergyReductionPlansAppService : SMACRAppService, IEnergyReductionPlansAppService
{
    private readonly IEnergyReductionPlanRepository energyReductionPlanRepository;
    private readonly IUserProfileRepository userProfileRepository;
    private readonly IEmissionFactorsRepository emissionFactorsRepository;

    public EnergyReductionPlansAppService(
        IEnergyReductionPlanRepository energyReductionPlanRepository, 
        IUserProfileRepository userProfileRepository, 
        IEmissionFactorsRepository emissionFactorsRepository
        )
    {
        this.energyReductionPlanRepository = energyReductionPlanRepository;
        this.userProfileRepository = userProfileRepository;
        this.emissionFactorsRepository = emissionFactorsRepository;
    }

    public async Task<IEnumerable<ReductionPerYearDto>> CreatePlan(IEnumerable<PlanChoosedPerYearDto> data)
    {
        var userProfile = await userProfileRepository.GetProfileWithConsumption();
    

        if (userProfile == null)
        {
            throw new EntityNotFoundException();
        }

        var reductionPlansList = await energyReductionPlanRepository.GetListAsync();
        var emissionFactors = await emissionFactorsRepository.GetListAsync(c => c.Country == userProfile.Location);

        int minYear = 2023;
        int maxYear = 2030;

        var result = new List<ReductionPerYearDto>();

        for(int i = minYear; i <= maxYear; i++)
        {
            var choosenPlans = data.FirstOrDefault(d => d.Year == i);
            var initialConsumation = userProfile.ElectricConsumptions
            .Where(c => c.StartDate >= new System.DateTime(i, 01, 01) && c.EndDate <= new System.DateTime(i, 12, 31))
            .Sum(c => c.EnergyConsumedInKwh);

            if (choosenPlans == null || choosenPlans.Plans.Length == 0)
            {
                result.Add(new ReductionPerYearDto { Year = i, Plans = new int[] { }, ReductionOfCO2InKg = 0, TotalEnergyConsumed = initialConsumation });
            }
            else
            {
                var plans = choosenPlans.Plans;


                var reductionInKWh = reductionPlansList.Where(p => plans.Contains(p.PlanNumber)).Sum(p => p.ReductionInKw);
                var reductionOfCO2InKg = reductionInKWh * emissionFactors.First(e => e.Year == i).ActualEmissionFactor;

                result.Add(new ReductionPerYearDto
                {
                    Year = i,
                    Plans = plans,
                    TotalEnergyConsumed = initialConsumation,
                    ReductionInKWh = reductionInKWh,
                    ReductionOfCO2InKg = reductionOfCO2InKg,
                });

            }
            
        }

        return result;
    }

    public async Task<IEnumerable<EnergyReductionPlanReadDto>> GetAllAsync()
    {
        var plans = await energyReductionPlanRepository.GetListAsync();

        return ObjectMapper.Map<IEnumerable<EnergyReductionPlan>, IEnumerable<EnergyReductionPlanReadDto>>(plans);
            
    }
}
