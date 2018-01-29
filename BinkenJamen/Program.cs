using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BinkenJamen
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//BinkRepository.InitializeBinks();
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();
	}
}