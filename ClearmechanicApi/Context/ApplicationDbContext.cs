using ClearmechanicApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClearmechanicApi.Context
{
	public class ApplicationDbContext: DbContext
	{
		public DbSet<Gender> Gender { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Movie> Movie { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
    }
}

