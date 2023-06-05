using HCLTech.SMACR.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace HCLTech.SMACR.Users;

public class UserProfileRepository : EfCoreRepository<SMACRDbContext, UserProfile, Guid>, IUserProfileRepository
{
    public UserProfileRepository(IDbContextProvider<SMACRDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
