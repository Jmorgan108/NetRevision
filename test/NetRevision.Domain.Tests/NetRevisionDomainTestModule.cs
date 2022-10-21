using NetRevision.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NetRevision;

[DependsOn(
    typeof(NetRevisionEntityFrameworkCoreTestModule)
    )]
public class NetRevisionDomainTestModule : AbpModule
{

}
