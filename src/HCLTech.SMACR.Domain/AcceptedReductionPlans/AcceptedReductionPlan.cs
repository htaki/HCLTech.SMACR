using HCLTech.SMACR.EnergyReductionPlans;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace HCLTech.SMACR.AcceptedReductionPlans;

public class AcceptedReductionPlan : AuditedEntity<Guid>
{
    private readonly List<EnergyReductionPlan> energyReductionPlans = new List<EnergyReductionPlan>();

    public int Year { get; private set; }

    public IEnumerable<EnergyReductionPlan> EnergyReductionPlans => energyReductionPlans.AsReadOnly();
   
}
