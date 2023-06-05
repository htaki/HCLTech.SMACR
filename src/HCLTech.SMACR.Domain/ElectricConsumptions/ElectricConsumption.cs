using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HCLTech.SMACR.ElectricConsumptions;

public class ElectricConsumption : FullAuditedEntity<Guid>
{
    public DateTime StartDate { get; private set; }

    public DateTime EndDate { get; private set; }

    public decimal EnergyConsumedInKwh { get; private set; }

    public ElectricConsumption(Guid id, DateTime startDate, DateTime endDate, decimal energyConsumedInKwh)
    {
        Id = id;
        StartDate = startDate;
        EndDate = endDate;
        EnergyConsumedInKwh = energyConsumedInKwh;
    }
}
