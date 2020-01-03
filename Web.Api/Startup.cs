using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CBDistro.Web.StartUp;

namespace CBDistro
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMemoryCache();

            services.AddMvc();

            services.AddSingleton<IConfiguration>(Configuration);

            ConfigureAppSettings(services);

            DependencyInjection.ConfigureServices(services, Configuration);

            Cors.ConfigureServices(services);

            Authentication.ConfigureServices(services, Configuration);

            MVC.ConfigureServices(services);

            SPA.ConfigureServices(services);

        }

        private void ConfigureAppSettings(IServiceCollection services)
        {
            services.AddOptions();
            //services.Configure<SecurityConfig>(Configuration.GetSection("SecurityConfig"));
            //services.Configure<JsonWebTokenConfig>(Configuration.GetSection("JsonWebTokenConfig"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            Authentication.Configure(app, env);

            Cors.Configure(app, env);

            //app.UseSignalR(routes =>
            //{
            //    routes.MapHub<ChatHub>("/chathub");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHttpsRedirection();
                app.UseDeveloperExceptionPage();
                app.UseHsts();
            }

            MVC.Configure(app, env);

            SPA.Configure(app, env);

            StaticFiles.Configure(app, env);
        }
    }
}
