using BinkenJamen.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BinkenJamen
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddTransient<IBinkRepository, BinkRepository>();
			services.AddMvc();
			services.AddEntityFrameworkSqlServer();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseDeveloperExceptionPage();
			app.UseStatusCodePages();
			app.UseStaticFiles();
			app.UseMvc(routes =>
			{ 
				routes.MapRoute(
					name: "default",
					template: "{Controller=Bink}/{action=Index}/{id?}");

				routes.MapRoute(
					name: "different",
					template: "{action=Index}/{Controller=Bink}/{id?}");
			});
		}
	}
}