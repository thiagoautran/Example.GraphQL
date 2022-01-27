using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<CarvedRockSchema>();
            services.AddScoped<CarvedRockQuery>();
            services.AddScoped<ProductType>();

            services.AddControllers();
            services.AddApiVersioning();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphQL<CarvedRockSchema>();
            app.UseGraphQLPlayground(new PlaygroundOptions());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
