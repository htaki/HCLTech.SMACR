using HCLTech.SMACR.Users;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HCLTech.SMACR.ElectricConsumptions;

public class ElectricConsumption : AuditedEntity<Guid> 
{
    public UserProfile UserProfile { get; set; }
    public Guid UserProfileId { get; set; }
    public DateTime StartDate { get; private set; }

    public DateTime EndDate { get; private set; }

    public decimal EnergyConsumedInKwh { get; private set; }

    public ElectricConsumption(Guid id,Guid userProfileId, DateTime startDate, DateTime endDate, decimal energyConsumedInKwh)
    {
        Id = id;
        UserProfileId = userProfileId;
        StartDate = startDate;
        EndDate = endDate;
        EnergyConsumedInKwh = energyConsumedInKwh;
    }

}
