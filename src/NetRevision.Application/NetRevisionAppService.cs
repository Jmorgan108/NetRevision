using System;
using System.Collections.Generic;
using System.Text;
using NetRevision.Localization;
using Volo.Abp.Application.Services;

namespace NetRevision;

/* Inherit your application services from this class.
 */
public abstract class NetRevisionAppService : ApplicationService
{
    protected NetRevisionAppService()
    {
        LocalizationResource = typeof(NetRevisionResource);
    }
}
