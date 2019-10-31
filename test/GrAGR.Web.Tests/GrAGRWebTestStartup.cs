using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace GrAGR
{
    public class GrAGRWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<GrAGRWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}