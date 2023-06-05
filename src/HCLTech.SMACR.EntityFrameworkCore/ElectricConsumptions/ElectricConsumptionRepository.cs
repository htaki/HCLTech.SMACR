using HCLTech.SMACR.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace HCLTech.SMACR.ElectricConsumptions;

public class ElectricConsumptionRepository : EfCoreRepository<SMACRDbContext, ElectricConsumption, Guid>, IElectricConsumptionRepository
{
    public ElectricConsumptionRepository(IDbContextProvider<SMACRDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
