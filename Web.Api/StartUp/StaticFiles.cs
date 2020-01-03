using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CBDistro.Web.StartUp
{
    public class StaticFiles
    {
        public static void ConfigureServices(IServiceCollection services)
        {
        }

        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
        }
    }
}