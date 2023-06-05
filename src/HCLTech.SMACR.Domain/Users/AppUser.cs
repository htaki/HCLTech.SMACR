using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace HCLTech.SMACR.Users;

public class UserProfile : AuditedAggregateRoot<Guid>
{
    public IdentityUser IdentityUser { get; private set; }
    public Guid IdentityUserId { get; private set; }

    public string Location { get; private set; }
    public string Workplace { get; private set; }
    public bool IsApartment { get; private set; }
    public int FamilySize { get; private set; }

    public UserProfile(Guid identityUserId,  string location, string workplace, bool isApartment, int familySize)
    {
        IdentityUserId = identityUserId;
        Location = location;
        Workplace = workplace;
        IsApartment = isApartment;
        FamilySize = familySize;
    }
}
