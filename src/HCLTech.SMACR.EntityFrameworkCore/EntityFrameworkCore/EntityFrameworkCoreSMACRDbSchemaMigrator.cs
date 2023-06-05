using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HCLTech.SMACR.Data;
using Volo.Abp.DependencyInjection;

namespace HCLTech.SMACR.EntityFrameworkCore;

public class EntityFrameworkCoreSMACRDbSchemaMigrator
    : ISMACRDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSMACRDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SMACRDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SMACRDbContext>()
            .Database
            .MigrateAsync();
    }
}
