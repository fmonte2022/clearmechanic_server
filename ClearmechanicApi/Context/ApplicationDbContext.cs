using ClearmechanicApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClearmechanicApi.Context
{
	public class ApplicationDbContext: DbContext
	{
		public DbSet<Gender> Genders { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Gender>(entity => { entity.ToTable("Gender"); });
            modelBuilder.Entity<Actor>(entity => { entity.ToTable("Actor"); });
            modelBuilder.Entity<User>(entity => { entity.ToTable("User"); });
            modelBuilder.Entity<Movie>(entity => { entity.ToTable("Movie"); });

            InsertUsers(modelBuilder);
            InsertGenders(modelBuilder);
            InsertActors(modelBuilder);
            InsertMovies(modelBuilder);
            InsertActorToMovies(modelBuilder);
        }

        //Method used to insert the actors associated to the movies by default
        private static void InsertActorToMovies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>().HasData(
               new MovieActor {
                   Id = 1,
                   MovieId = 1,
                   ActorId = 1,
               }
            );
            modelBuilder.Entity<MovieActor>().HasData(
                new MovieActor {
                    Id = 2,
                    MovieId = 1,
                    ActorId = 2,
                }
           );
            modelBuilder.Entity<MovieActor>().HasData(
                 new MovieActor {
                     Id = 3,
                     MovieId = 2,
                     ActorId = 3,
                 }
             );
            modelBuilder.Entity<MovieActor>().HasData(
                new MovieActor {
                    Id = 4,
                    MovieId = 2,
                    ActorId = 4
                }
            );
        }

        //Method used to insert the movies by default
        private static void InsertMovies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie {
                    Id = 1,
                    Title = "Piratas del Caribe",
                    GenderId = 2,
                    Year = 2011
                }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie {
                    Id = 2,
                    Title = "Rocky IV",
                    GenderId = 5,
                    Year = 1990
                }
            );
        }

        //Method used to insert the actors by default
        private static void InsertActors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                 new Actor {
                     Id = 1,
                     Name = "Johnny Depp",
                 }
            );
            modelBuilder.Entity<Actor>().HasData(
                new Actor {
                    Id = 2,
                    Name = "Orlando Bloom",
                }
            );
            modelBuilder.Entity<Actor>().HasData(
                new Actor {
                    Id = 3,
                    Name = "Sylvester Stallone",
                }
            );
            modelBuilder.Entity<Actor>().HasData(
                new Actor {
                    Id = 4,
                    Name = "Carl Weathers",
                }
            );
        }

        //Method used to insert the genders by default
        private static void InsertGenders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(
                new Gender {
                    Id = 1,
                    NameEs = "Acción",
                    NameEn = "Action",
                }
            );
            modelBuilder.Entity<Gender>().HasData(
                new Gender {
                    Id = 2,
                    NameEs = "Aventura",
                    NameEn = "Adventure",
                }
            );
            modelBuilder.Entity<Gender>().HasData(
                 new Gender {
                     Id = 3,
                     NameEs = "Terror",
                     NameEn = "Terror",
                 }
            );
            modelBuilder.Entity<Gender>().HasData(
                new Gender {
                    Id = 4,
                    NameEs = "Comedia",
                    NameEn = "Comedy",
                }
            );
            modelBuilder.Entity<Gender>().HasData(
                new Gender {
                    Id = 5,
                    NameEs = "Drama",
                    NameEn = "Drama",
                }
            );
        }

        //Method used to insert the users by default
        private static void InsertUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {
                    Id = 1,
                    Name = "Admin",
                    Username = "Admin",
                    Password = "21232f297a57a5a743894a0e4a801fc3",
                }
            );
        }
    }
}

