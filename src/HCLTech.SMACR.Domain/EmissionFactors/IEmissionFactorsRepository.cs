using System;
using Volo.Abp.Domain.Repositories;

namespace HCLTech.SMACR.EmissionFactors;

public interface IEmissionFactorsRepository : IRepository<EmissionFactor, Guid>
{
}
