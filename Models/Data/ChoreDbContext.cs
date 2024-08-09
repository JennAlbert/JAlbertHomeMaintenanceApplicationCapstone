using Microsoft.EntityFrameworkCore;
using JAlbertHomeMaintenanceCapstone.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace JAlbertHomeMaintenanceCapstone.Models.Data
{
	public class ChoreDbContext : DbContext
	{
		public DbSet<UserChore> MyChores { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlite
			($"C:\\Users\\jenni\\OneDrive\\Desktop\\JAlbertHomeMaintenanceCapstone\\Files\\UserChoreDB.db");
		}
	}
    
}