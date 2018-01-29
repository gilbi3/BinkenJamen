using BinkenJamen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;

namespace BinkenJamen.Data
{
	public class BinkContext : DbContext
	{
		public DbSet<Bink> Binks { get; set; }

		public static readonly Microsoft.Extensions.Logging.LoggerFactory MyLoggerFactory
			= new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = "Server = tcp:talula.database.windows.net,1433; Initial Catalog = bink; Persist Security Info = False; User ID = gilbi3; Password = Algernon!7; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
			//string connectionString = Environment.GetEnvironmentVariable("AZURE_CONNECTION_STRING");
			//Comment and uncomment to disable logging.
			optionsBuilder.UseLoggerFactory(MyLoggerFactory)
				.UseSqlServer(connectionString);
		}
	}
}