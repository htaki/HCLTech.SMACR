using HCLTech.SMACR.EnergyReductionPlans;
using HCLTech.SMACR.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace HCLTech.SMACR.Users;

public class EnergyReductionPlanRepository : EfCoreRepository<SMACRDbContext, EnergyReductionPlan, Guid>, IEnergyReductionPlanRepository
{
    public EnergyReductionPlanRepository(IDbContextProvider<SMACRDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
