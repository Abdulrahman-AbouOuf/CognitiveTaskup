using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using CognitiveTask.Models;

[assembly: OwinStartup(typeof(CognitiveTask.App_Start.Startup))]

namespace CognitiveTask.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

        }
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.   
            services.AddMvc();
            services.AddSingleton<Icampaignrepo, campaignrepo>();
        }
    }
}
