namespace HCLTech.SMACR.EnergyReductionPlans;

public class ReductionPerYearDto
{
    public int Year { get; set; }

    public int[] Plans { get; set;}

    public decimal ReductionOfCO2InKg { get; set; }

    public decimal ReductionInKWh { get; set; }

    public decimal TotalEnergyConsumed { get; set; }
}