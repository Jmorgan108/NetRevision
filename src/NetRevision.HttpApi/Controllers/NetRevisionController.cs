using NetRevision.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NetRevision.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NetRevisionController : AbpControllerBase
{
    protected NetRevisionController()
    {
        LocalizationResource = typeof(NetRevisionResource);
    }
}
