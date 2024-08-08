using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Chat_app.entity_framework
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{
		}

		public DbSet<Message> Messages { get; set; }
	}
}
