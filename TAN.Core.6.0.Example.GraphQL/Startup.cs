using System;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TAN.Core._6._0.Example.ApplicationCore.Interfaces;
using TAN.Core._6._0.Example.ApplicationCore.Queries;
using TAN.Core._6._0.Example.ApplicationCore.Schemas;
using TAN.Core._6._0.Example.ApplicationCore.Types;
using TAN.Core._6._0.Example.Infrastructure.Schemas;

namespace TAN.Core._6._0.Example.GraphQL
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ProductType>();
            services.AddSingleton<CarvedRockQuery>();
            services.AddSingleton<ISchema, CarvedRockSchema>();

            services.AddSingleton<IProductRepository, ProductRepository>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            })
            .AddSystemTextJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseGraphQL<ISchema>();
            app.UseGraphQLAltair();
        }
    }
}