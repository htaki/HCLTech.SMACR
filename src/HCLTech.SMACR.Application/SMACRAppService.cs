using System;
using System.Collections.Generic;
using System.Text;
using HCLTech.SMACR.Localization;
using Volo.Abp.Application.Services;

namespace HCLTech.SMACR;

/* Inherit your application services from this class.
 */
public abstract class SMACRAppService : ApplicationService
{
    protected SMACRAppService()
    {
        LocalizationResource = typeof(SMACRResource);
    }
}
