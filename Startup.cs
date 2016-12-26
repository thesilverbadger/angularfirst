using Microsoft.AspNetCore.Builder;

namespace AngularFirst
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();

            
        }
    }
}