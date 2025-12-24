using Microsoft.EntityFrameworkCore;

namespace AutoLocPro.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

	public DbSet<Vehicle> Vehicles { get; set; }
	public DbSet<Booking> Bookings { get; set; }
}
