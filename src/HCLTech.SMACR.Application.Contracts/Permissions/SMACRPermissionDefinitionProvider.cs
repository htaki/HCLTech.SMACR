using HCLTech.SMACR.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HCLTech.SMACR.Permissions;

public class SMACRPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SMACRPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SMACRPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SMACRResource>(name);
    }
}
