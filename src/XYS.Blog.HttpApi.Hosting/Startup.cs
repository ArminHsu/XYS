using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace XYS.Blog.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<BlogWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
