using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using YouTubeManagerByFerJS.Domain.Interfaces;
using YouTubeManagerByFerJS.Domain.Models;
using YouTubeManagerByFerJS.ExternalService.API;

namespace YouTubeManagerByFerJS
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IYouTubeData, YouTubeData>();
            services.AddSingleton<IGetYouTubeData, GetYouTubeData>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
