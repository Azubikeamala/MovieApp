using Microsoft.EntityFrameworkCore;
namespace MovieApp.Entities
{
    public class MovieDbContext : DbContext
    {

        public MovieDbContext(DbContextOptions<MovieDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        //This will create a table named Reviews in the database; a second table
        //public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    MovieId = 1,
                    Name = "The Shawshank Redemption",
                    Year = "1994",
                    Rating = 1
                },
                new Movie()
                {
                    MovieId = 2,
                    Name = "The Godfather",
                    Year = "1972",
                    Rating = 5
                },
                new Movie()
                {
                    MovieId = 3,
                    Name = "The Dark Knight",
                    Year = "2008",
                    Rating = 3
                },
                new Movie()
                {
                    MovieId = 4,
                    Name = "The Godfather: Part II",
                    Year = "1974",
                    Rating = 4
                },
                new Movie()
                {
                    MovieId = 5,
                    Name = "The Lord of the Rings: The Return of the King",
                    Year = "2003",
                    Rating = 5
                }
            );
        }
    }
}
