using HCLTech.SMACR.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace HCLTech.SMACR.EmissionFactors;

public class EmissionFactorsRepository : EfCoreRepository<SMACRDbContext, EmissionFactor, Guid>, IEmissionFactorsRepository
{
    public EmissionFactorsRepository(IDbContextProvider<SMACRDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
