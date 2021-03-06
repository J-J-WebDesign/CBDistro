﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CBDistro.Services;
using System;
//using CBDistro.Services.Interfaces.Security;
//using Amazon.S3;
using CBDistro.Data.Providers;
using CBDistro.Services.Interfaces;

namespace CBDistro.Web.StartUp
{
    public class DependencyInjection
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            if (configuration is IConfigurationRoot)
            {
                services.AddSingleton<IConfigurationRoot>(configuration as IConfigurationRoot);   // IConfigurationRoot
            }

            services.AddSingleton<IConfiguration>(configuration);   // IConfiguration explicitly
          
            string connString = configuration.GetConnectionString("Default"); 
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2
            // The are a number of differe Add* methods you can use. Please verify which one you
            // should be using services.AddScoped<IMyDependency, MyDependency>();

            // services.AddTransient<IOperationTransient, Operation>();

            // services.AddScoped<IOperationScoped, Operation>();

            // services.AddSingleton<IOperationSingleton, Operation>();

            //services.AddSingleton<IAuthenticationService<int>, WebAuthenticationService>();

            services.AddSingleton<CBDistro.Data.Providers.IDataProvider, SqlDataProvider>(delegate (IServiceProvider provider)
            {
                return new SqlDataProvider(connString);
            }
            );
           
            services.AddSingleton<IFAQServices, FAQServices>();
            services.AddSingleton<IProductService, ProductServices>();
        }
        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
        }
    }
}