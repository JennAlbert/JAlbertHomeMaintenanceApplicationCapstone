using Microsoft.EntityFrameworkCore;
using JAlbertHomeMaintenanceCapstone.Models;
using Microsoft.Extensions.Configuration;

namespace JAlbertHomeMaintenanceCapstone.Models.Data
{
	public class ChoreDbContext : DbContext
	{
		protected readonly IConfiguration Configuration;

		public ChoreDbContext(IConfiguration configuration)
		{
			Configuration = configuration;

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(Configuration.GetConnectionString("ChoreDbConnectionString"));
		}

    }
}