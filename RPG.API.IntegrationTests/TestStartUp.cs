using Microsoft.Extensions.Configuration;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RPG.API.Database;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace RPG.API.IntegrationTests
{
    public class TestStartUp
    {
        public IConfiguration Configuration { get; }

        public TestStartUp(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase(Guid.NewGuid().ToString()));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
