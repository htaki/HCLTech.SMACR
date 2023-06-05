using HCLTech.SMACR.EmissionFactors;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HCLTech.SMACR.Users;


public class UserProfileUpdateDto : IValidatableObject
{
    [Required]
    public string Location { get;  set; }

    public string Workplace { get;  set; }

    [Required]
    public bool IsApartment { get;  set; }


    [Required]
    public int FamilySize { get;  set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        string[] validLocations = new string[] { CountriesCodes.France, CountriesCodes.Belguim, CountriesCodes.Germany, CountriesCodes.UnitedKingdom };
        
        if (!validLocations.Contains(Location))
        {
            yield return new ValidationResult(
                $"Location should be one of the following: {string.Join(", ", validLocations)}",
                new[] { nameof(Location) }
            );
        }

        if (!string.IsNullOrEmpty(Workplace) && !validLocations.Contains(Location))
        {
            yield return new ValidationResult(
                $"Location should be one of the following: {string.Join(", ", validLocations)}",
                new[] { nameof(Workplace) }
            );
        }
    }
}


public class ReadProfileUpdateDto
{
    public string Username { get; set; }

    public string Location { get; set; }

    public string Workplace { get; set; }

    public bool IsApartment { get; set; }


    public int FamilySize { get; set; }


}
