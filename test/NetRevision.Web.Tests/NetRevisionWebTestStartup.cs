using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace NetRevision;

public class NetRevisionWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<NetRevisionWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
