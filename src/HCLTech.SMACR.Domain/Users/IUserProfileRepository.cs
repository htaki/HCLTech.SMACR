using System;
using Volo.Abp.Domain.Repositories;

namespace HCLTech.SMACR.Users;

public interface IUserProfileRepository : IRepository<UserProfile, Guid>
{
}
