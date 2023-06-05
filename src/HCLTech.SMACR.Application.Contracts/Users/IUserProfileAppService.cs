using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Services;

namespace HCLTech.SMACR.Users;

public interface IUserProfileAppService : IApplicationService
{
    Task UpdateAsync(Guid id, UserProfileUpdateDto input);
}
