using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetRevision.Data;
using Volo.Abp.DependencyInjection;

namespace NetRevision.EntityFrameworkCore;

public class EntityFrameworkCoreNetRevisionDbSchemaMigrator
    : INetRevisionDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNetRevisionDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NetRevisionDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NetRevisionDbContext>()
            .Database
            .MigrateAsync();
    }
}
