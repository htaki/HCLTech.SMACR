using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace HCLTech.SMACR.Users;

public interface IUserProfileRepository : IRepository<UserProfile, Guid>
{
    Task<UserProfile> GetByIdentiyUserId(Guid? id);
}
