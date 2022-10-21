using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace NetRevision.Web;

[Dependency(ReplaceServices = true)]
public class NetRevisionBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NetRevision";
}
