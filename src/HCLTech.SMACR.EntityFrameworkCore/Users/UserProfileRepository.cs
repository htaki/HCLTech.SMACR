using HCLTech.SMACR.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace HCLTech.SMACR.Users;

public class UserProfileRepository : EfCoreRepository<SMACRDbContext, UserProfile, Guid>, IUserProfileRepository
{
    public UserProfileRepository(IDbContextProvider<SMACRDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<UserProfile?> GetByIdentiyUserId(Guid? id)
    {
        var dbSet = await GetDbSetAsync();

        return  await dbSet.Where(e => e.IdentityUserId == id).FirstOrDefaultAsync();
    }
}
