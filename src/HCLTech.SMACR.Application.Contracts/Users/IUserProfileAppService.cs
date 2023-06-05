using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace HCLTech.SMACR.Users;

public interface IUserProfileAppService : IApplicationService
{
    Task UpdateAsync(UserProfileUpdateDto input);
    Task<ReadProfileUpdateDto> GetAsync();
}
