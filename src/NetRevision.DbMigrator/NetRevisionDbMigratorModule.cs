using NetRevision.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace NetRevision.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NetRevisionEntityFrameworkCoreModule),
    typeof(NetRevisionApplicationContractsModule)
    )]
public class NetRevisionDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
