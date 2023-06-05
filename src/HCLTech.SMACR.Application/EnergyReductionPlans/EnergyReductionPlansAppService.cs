using HCLTech.SMACR.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLTech.SMACR.EnergyReductionPlans;

public class EnergyReductionPlansAppService : SMACRAppService, IEnergyReductionPlansAppService
{
    private readonly IEnergyReductionPlanRepository energyReductionPlanRepository;

    public EnergyReductionPlansAppService(IEnergyReductionPlanRepository energyReductionPlanRepository)
    {
        this.energyReductionPlanRepository = energyReductionPlanRepository;
    }

    public async Task<IEnumerable<EnergyReductionPlanReadDto>> GetAllAsync()
    {
        var plans = await energyReductionPlanRepository.GetListAsync();

        return ObjectMapper.Map<IEnumerable<EnergyReductionPlan>, IEnumerable<EnergyReductionPlanReadDto>>(plans);
            
    }
}
