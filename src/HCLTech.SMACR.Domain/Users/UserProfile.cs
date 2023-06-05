using HCLTech.SMACR.AcceptedReductionPlans;
using HCLTech.SMACR.ElectricConsumptions;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace HCLTech.SMACR.Users;

public class UserProfile : FullAuditedAggregateRoot<Guid>
{
    private readonly List<ElectricConsumption> electricConsumptions = new List<ElectricConsumption>();
    private readonly List<AcceptedReductionPlan> acceptedReductionPlans = new List<AcceptedReductionPlan>();

    public IdentityUser IdentityUser { get; private set; }
    public Guid IdentityUserId { get; private set; }

    public string Location { get; private set; }
    public string Workplace { get; private set; }
    public bool IsApartment { get; private set; }
    public int FamilySize { get; private set; }
    public IReadOnlyCollection<ElectricConsumption> ElectricConsumptions => electricConsumptions.AsReadOnly();
    public IReadOnlyCollection<AcceptedReductionPlan> AcceptedReductionPlans => acceptedReductionPlans.AsReadOnly();

    public UserProfile(Guid id, Guid identityUserId,  string location, string workplace, bool isApartment, int familySize)
        :base(id)
    {
        IdentityUserId = identityUserId;
        Location = location;
        Workplace = workplace;
        IsApartment = isApartment;
        FamilySize = familySize;
    }

    public void Update(string location, string workplace, bool isApartment, int familySize)
    {
        Location = location;
        Workplace = workplace;
        IsApartment = isApartment;
        FamilySize = familySize;
    }

}
