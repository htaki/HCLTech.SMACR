using HCLTech.SMACR.EmissionFactors;
using HCLTech.SMACR.EnergyReductionPlans;
using HCLTech.SMACR.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace HCLTech.SMACR.Data;

public class InitialDataSetDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IEnergyReductionPlanRepository energyReductionPlanRepository;
    private readonly IEmissionFactorsRepository emissionFactorsRepository;

    public InitialDataSetDataSeedContributor(
        IEnergyReductionPlanRepository energyReductionPlanRepository,
        IEmissionFactorsRepository emissionFactorsRepository)
    {
        this.energyReductionPlanRepository = energyReductionPlanRepository;
        this.emissionFactorsRepository = emissionFactorsRepository;
    }
    public async Task SeedAsync(DataSeedContext context)
    {
        if(await energyReductionPlanRepository.CountAsync() == 0)
        {
            await energyReductionPlanRepository.InsertManyAsync(new List<EnergyReductionPlan>
            {
                new EnergyReductionPlan(Guid.NewGuid(),1,"Buy Thermostat", 280 ),
                new EnergyReductionPlan(Guid.NewGuid(),2,"LED lights", 100 ),
                new EnergyReductionPlan(Guid.NewGuid(),3,"Replace old gadgets with 5-star gadget", 300 ),
                new EnergyReductionPlan(Guid.NewGuid(),4,"Reduce Thermostat by 2 deg ", 260 ),
                new EnergyReductionPlan(Guid.NewGuid(),5,"Solar", 500 ),
                new EnergyReductionPlan(Guid.NewGuid(),6,"Turn off devices on standby", 150 ),
            });
        }


        if (await emissionFactorsRepository.CountAsync() == 0)
        {
            await emissionFactorsRepository.InsertManyAsync(new List<EmissionFactor>
            {
                //France
                new EmissionFactor(Guid.NewGuid(), 2020, CountriesCodes.France, 0.05m),
                new EmissionFactor(Guid.NewGuid(), 2021, CountriesCodes.France, 0.05m),
                new EmissionFactor(Guid.NewGuid(), 2022, CountriesCodes.France, 0.04m),
                new EmissionFactor(Guid.NewGuid(), 2023, CountriesCodes.France, 0.04m),
                new EmissionFactor(Guid.NewGuid(), 2024, CountriesCodes.France, 0.04m),
                new EmissionFactor(Guid.NewGuid(), 2025, CountriesCodes.France, 0.03m),
                new EmissionFactor(Guid.NewGuid(), 2026, CountriesCodes.France, 0.03m),
                new EmissionFactor(Guid.NewGuid(), 2027, CountriesCodes.France, 0.03m),
                new EmissionFactor(Guid.NewGuid(), 2028, CountriesCodes.France, 0.03m),
                new EmissionFactor(Guid.NewGuid(), 2029, CountriesCodes.France, 0.02m),
                new EmissionFactor(Guid.NewGuid(), 2030, CountriesCodes.France, 0.02m),

                //Belgium
                new EmissionFactor(Guid.NewGuid(), 2020, CountriesCodes.Belguim, 0.16m),
                new EmissionFactor(Guid.NewGuid(), 2021, CountriesCodes.Belguim, 0.17m),
                new EmissionFactor(Guid.NewGuid(), 2022, CountriesCodes.Belguim, 0.18m),
                new EmissionFactor(Guid.NewGuid(), 2023, CountriesCodes.Belguim, 0.19m),
                new EmissionFactor(Guid.NewGuid(), 2024, CountriesCodes.Belguim, 0.19m),
                new EmissionFactor(Guid.NewGuid(), 2025, CountriesCodes.Belguim, 0.20m),
                new EmissionFactor(Guid.NewGuid(), 2026, CountriesCodes.Belguim, 0.20m),
                new EmissionFactor(Guid.NewGuid(), 2027, CountriesCodes.Belguim, 0.20m),
                new EmissionFactor(Guid.NewGuid(), 2028, CountriesCodes.Belguim, 0.19m),
                new EmissionFactor(Guid.NewGuid(), 2029, CountriesCodes.Belguim, 0.19m),
                new EmissionFactor(Guid.NewGuid(), 2030, CountriesCodes.Belguim, 0.19m),


                 //UK
                new EmissionFactor(Guid.NewGuid(), 2020, CountriesCodes.UnitedKingdom, 0.23m),
                new EmissionFactor(Guid.NewGuid(), 2021, CountriesCodes.UnitedKingdom, 0.21m),
                new EmissionFactor(Guid.NewGuid(), 2022, CountriesCodes.UnitedKingdom, 0.19m),
                new EmissionFactor(Guid.NewGuid(), 2023, CountriesCodes.UnitedKingdom, 0.18m),
                new EmissionFactor(Guid.NewGuid(), 2024, CountriesCodes.UnitedKingdom, 0.16m),
                new EmissionFactor(Guid.NewGuid(), 2025, CountriesCodes.UnitedKingdom, 0.14m),
                new EmissionFactor(Guid.NewGuid(), 2026, CountriesCodes.UnitedKingdom, 0.12m),
                new EmissionFactor(Guid.NewGuid(), 2027, CountriesCodes.UnitedKingdom, 0.10m),
                new EmissionFactor(Guid.NewGuid(), 2028, CountriesCodes.UnitedKingdom, 0.09m),
                new EmissionFactor(Guid.NewGuid(), 2029, CountriesCodes.UnitedKingdom, 0.07m),
                new EmissionFactor(Guid.NewGuid(), 2030, CountriesCodes.UnitedKingdom, 0.05m),

                //DE
                new EmissionFactor(Guid.NewGuid(), 2020, CountriesCodes.Germany, 0.34m),
                new EmissionFactor(Guid.NewGuid(), 2021, CountriesCodes.Germany, 0.33m),
                new EmissionFactor(Guid.NewGuid(), 2022, CountriesCodes.Germany, 0.31m),
                new EmissionFactor(Guid.NewGuid(), 2023, CountriesCodes.Germany, 0.30m),
                new EmissionFactor(Guid.NewGuid(), 2024, CountriesCodes.Germany, 0.29m),
                new EmissionFactor(Guid.NewGuid(), 2025, CountriesCodes.Germany, 0.27m),
                new EmissionFactor(Guid.NewGuid(), 2026, CountriesCodes.Germany, 0.25m),
                new EmissionFactor(Guid.NewGuid(), 2027, CountriesCodes.Germany, 0.24m),
                new EmissionFactor(Guid.NewGuid(), 2028, CountriesCodes.Germany, 0.22m),
                new EmissionFactor(Guid.NewGuid(), 2029, CountriesCodes.Germany, 0.20m),
                new EmissionFactor(Guid.NewGuid(), 2030, CountriesCodes.Germany, 0.18m),

            });
        }
    }
}
