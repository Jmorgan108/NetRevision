using Volo.Abp.Modularity;

namespace NetRevision;

[DependsOn(
    typeof(NetRevisionApplicationModule),
    typeof(NetRevisionDomainTestModule)
    )]
public class NetRevisionApplicationTestModule : AbpModule
{

}
