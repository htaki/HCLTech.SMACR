using HCLTech.SMACR.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Users;

namespace HCLTech.SMACR.Users;

public class UserProfileRepository : EfCoreRepository<SMACRDbContext, UserProfile, Guid>, IUserProfileRepository
{
    private readonly ICurrentUser currentUser;

    public UserProfileRepository(IDbContextProvider<SMACRDbContext> dbContextProvider , ICurrentUser currentUser) : base(dbContextProvider)
    {
        this.currentUser = currentUser;
    }

    public async Task<UserProfile?> GetByIdentiyUserId(Guid? id)
    {
        var dbSet = await GetDbSetAsync();

        return  await dbSet.Where(e => e.IdentityUserId == id).FirstOrDefaultAsync();
    }

    public async Task<UserProfile?> GetProfileWithConsumption()
    {
        var dbSet = await GetDbSetAsync();

        return await dbSet
            .Include(u => u.ElectricConsumptions)
            .Where(e => e.IdentityUserId == currentUser.Id)
            .FirstOrDefaultAsync();
    }
}
