using Volo.Abp.Identity;

namespace HCLTech.SMACR.Users;

public class ApplicationUser : IdentityUser
{
    public string NewProperty { get; set; }
}
