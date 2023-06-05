using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Users;

namespace HCLTech.SMACR.Users;

[Authorize]
public class UserProfileAppService : SMACRAppService, IUserProfileAppService
{
    private readonly ICurrentUser currentUser;
    private readonly IUserProfileRepository userProfileRepository;

    public UserProfileAppService(ICurrentUser currentUser, IUserProfileRepository userProfileRepository)
    {
        this.currentUser = currentUser;
        this.userProfileRepository = userProfileRepository;
    }

    public async Task<ReadProfileUpdateDto> GetAsync()
    {
        var userProfile = await userProfileRepository.GetByIdentiyUserId(currentUser.Id);
        if (userProfile == null)
        {
            return new ReadProfileUpdateDto { Username = currentUser.Name };
        }
        else
        {
            return new ReadProfileUpdateDto {
                Username = currentUser.Name,
                Location = userProfile.Location,
                IsApartment = userProfile.IsApartment,
                Workplace = userProfile.Workplace,
                FamilySize = userProfile.FamilySize,
            
            };
        }
    }

    public async Task UpdateAsync(UserProfileUpdateDto input)
    {
        var userProfile = await userProfileRepository.GetByIdentiyUserId(currentUser.Id);
        if (userProfile == null)
        {
            userProfile = new UserProfile(Guid.NewGuid(), currentUser.Id.Value, input.Location, input.Workplace, input.IsApartment, input.FamilySize);
            await userProfileRepository.InsertAsync(userProfile);
        }
        else
        {
            if (userProfile.IdentityUserId != currentUser.Id)
            {
                throw new BusinessException("Not Authorized");
            }

            userProfile.Update(input.Location, input.Workplace, input.IsApartment, input.FamilySize);
        }

    }
}
