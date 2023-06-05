using HCLTech.SMACR.EnergyReductionPlans;
using System;
using Volo.Abp.Domain.Repositories;

namespace HCLTech.SMACR.Users;

public interface IEnergyReductionPlanRepository : IRepository<EnergyReductionPlan, Guid>
{
}
