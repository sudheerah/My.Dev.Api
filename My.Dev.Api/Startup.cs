using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using My.Dev.Api.Config;
using My.Dev.Api.Services;

namespace My.Dev.Api
{
    /// <summary>
    /// Thi is convention method rather than inheritance
    /// </summary>
    public class Startup
    {
        private readonly ConfigurationSettings _configurationSettings;

        public Startup(IConfiguration configuration)   // here it will inject configuration settings vis web host builder
        {
            _configurationSettings = configuration.Get<ConfigurationSettings>();
        }

        /// <summary>
        /// Configure Services
        ///  this will be inject using DI framework at runtime. This can inject all the dependency services that needed by the application through DI
        /// framework
        /// </summary>
        /// <param name="services">Service Collection</param>
        public void ConfigureServices(IServiceCollection services)

        {
            services
                .AddSingleton(_configurationSettings)
                .AddSingleton<ICartService, CartService>();

            services
                .AddMvc();  // This extention method add number of services needed from .Core mvc to the collection
        }

        /// <summary>
        /// This is other mandatory method to setup middle where pipeline and then control how app process http request
        /// IApplicationBuilder will build the middleware pineapple
        /// IHostingEnvironment provide info how currently application is hosted
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
    }
}