using System.Threading.Tasks;

namespace HCLTech.SMACR.Data;

public interface ISMACRDbSchemaMigrator
{
    Task MigrateAsync();
}
