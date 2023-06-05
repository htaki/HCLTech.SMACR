using HCLTech.SMACR.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HCLTech.SMACR.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SMACREntityFrameworkCoreModule),
    typeof(SMACRApplicationContractsModule)
    )]
public class SMACRDbMigratorModule : AbpModule
{

}
