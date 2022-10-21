using NetRevision.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace NetRevision.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class NetRevisionPageModel : AbpPageModel
{
    protected NetRevisionPageModel()
    {
        LocalizationResourceType = typeof(NetRevisionResource);
    }
}
