using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HCLTech.SMACR.ElectricConsumptions;

public class ElectricConsumptionDto : IValidatableObject
{
    public DateTime StartDate { get;  set; }

    public DateTime EndDate { get;  set; }

    public decimal EnergyConsumedInKwh { get;  set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if(EnergyConsumedInKwh < 0)
        {
            yield return new ValidationResult(
            $"Energy consumed should be a positive number",
            new[] { nameof(EnergyConsumedInKwh) }
            );
        }

        if (StartDate >= EndDate)
        {
            yield return new ValidationResult(
            $"Start date should be prior to end date",
            new[] { nameof(StartDate) , nameof(EndDate) }
            );
        }
    }
}