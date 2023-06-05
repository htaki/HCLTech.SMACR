using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HCLTech.SMACR;

[Dependency(ReplaceServices = true)]
public class SMACRBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SMACR";
}
