using System;
using System.Threading.Tasks;

namespace HCLTech.SMACR.Users;

public class UserProfileAppService : SMACRAppService, IUserProfileAppService
{
    public Task UpdateAsync(Guid id, UserProfileUpdateDto input)
    {
        throw new NotImplementedException();
    }
}
