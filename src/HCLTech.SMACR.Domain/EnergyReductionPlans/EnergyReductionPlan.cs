using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace HCLTech.SMACR.EnergyReductionPlans;

public class EnergyReductionPlan : Entity<Guid>
{
    [Required]
    public int PlanNumber { get; private set; }

    [MaxLength(255)]
    public string Name { get; private set; }

    [Required]
    public decimal ReductionInKw { get; private set; }

    public EnergyReductionPlan(Guid id, int planNumber, string name, decimal reductionInKw)
    {
        Id = id;
        PlanNumber = planNumber;
        Name = name;
        ReductionInKw = reductionInKw;
    }
}
