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

    public InitialDataSetDataSeedContributor(IEnergyReductionPlanRepository energyReductionPlanRepository)
    {
        this.energyReductionPlanRepository = energyReductionPlanRepository;
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
    }
}
