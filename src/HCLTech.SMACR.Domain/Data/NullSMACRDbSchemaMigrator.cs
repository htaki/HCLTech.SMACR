using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HCLTech.SMACR.Data;

/* This is used if database provider does't define
 * ISMACRDbSchemaMigrator implementation.
 */
public class NullSMACRDbSchemaMigrator : ISMACRDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
