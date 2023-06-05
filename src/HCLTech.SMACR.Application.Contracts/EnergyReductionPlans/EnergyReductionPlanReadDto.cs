using System;

namespace HCLTech.SMACR.EnergyReductionPlans;

public class EnergyReductionPlanReadDto
{
    public Guid Id { get;  set; }

    public int PlanNumber { get;  set; }

    public string Name { get;  set; }

    public decimal ReductionInKw { get;  set; }
 
}
