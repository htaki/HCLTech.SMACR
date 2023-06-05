using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace HCLTech.SMACR.ElectricConsumptions;

public interface IElectricConsumptionsAppService : IApplicationService
{

    public Task InsertElectricConsumption(ElectricConsumptionDto[] electricConsumptionDtos);
    public Task DeleteElectricConsumption();
    public Task<IEnumerable<ElectricConsumptionDto>> GetElectricConsumption();

}
