using System.ComponentModel.DataAnnotations;

namespace HCLTech.SMACR.Users;


public class UserProfileUpdateDto
{
    [Required]
    public string Location { get;  set; }

    public string Workplace { get;  set; }

    [Required]
    public bool IsApartment { get;  set; }


    [Required]
    public int FamilySize { get;  set; }

}
