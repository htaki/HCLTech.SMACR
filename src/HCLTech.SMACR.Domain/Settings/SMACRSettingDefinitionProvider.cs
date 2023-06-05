using Volo.Abp.Settings;

namespace HCLTech.SMACR.Settings;

public class SMACRSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SMACRSettings.MySetting1));
    }
}
