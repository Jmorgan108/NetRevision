using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NetRevision.Data;

/* This is used if database provider does't define
 * INetRevisionDbSchemaMigrator implementation.
 */
public class NullNetRevisionDbSchemaMigrator : INetRevisionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
