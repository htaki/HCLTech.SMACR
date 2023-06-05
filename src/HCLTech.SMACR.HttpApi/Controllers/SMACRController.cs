using HCLTech.SMACR.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HCLTech.SMACR.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SMACRController : AbpControllerBase
{
    protected SMACRController()
    {
        LocalizationResource = typeof(SMACRResource);
    }
}
