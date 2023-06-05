using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using System.Collections.Generic;

namespace HCLTech.SMACR.EnergyReductionPlans;

public interface IEnergyReductionPlansAppService : IApplicationService
{
    Task<IEnumerable<EnergyReductionPlanReadDto>> GetAllAsync();
}
