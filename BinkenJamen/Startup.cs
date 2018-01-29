﻿using BinkenJamen.Models;
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
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseDeveloperExceptionPage();
			app.UseStatusCodePages();
			app.UseStaticFiles();
			app.UseMvc(routes =>
			{
				//Need additional routing information.
				routes.MapRoute(
					name: "default",
					template: "{Controller=Bink}/{action=Index}/{id?}");
			});
		}
	}
}