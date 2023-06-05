using HCLTech.SMACR.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HCLTech.SMACR;

[DependsOn(
    typeof(SMACREntityFrameworkCoreTestModule)
    )]
public class SMACRDomainTestModule : AbpModule
{

}
