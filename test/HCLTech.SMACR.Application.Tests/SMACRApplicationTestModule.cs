using Volo.Abp.Modularity;

namespace HCLTech.SMACR;

[DependsOn(
    typeof(SMACRApplicationModule),
    typeof(SMACRDomainTestModule)
    )]
public class SMACRApplicationTestModule : AbpModule
{

}
