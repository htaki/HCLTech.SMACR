using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace HCLTech.SMACR.ElectricConsumptions;

public interface IElectricConsumptionRepository: IRepository<ElectricConsumption, Guid> 
{
}