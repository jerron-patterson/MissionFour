using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MissionFour.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {

        }
        public DbSet<movieEntry> entry { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<movieEntry>().HasData(
                new movieEntry
                {
                    movieID = 1,
                    category = "Action",
                    title = "Winter Soilder",
                    year = 2016,
                    director = "Jim Hentsen",
                    rating = "PG-13"
                },
                new movieEntry
                {
                    movieID = 2,
                    category = "Action",
                    title = "Civil War",
                    year = 2019,
                    director = "Jim Hentsen",
                    rating = "PG-13"
                },
                new movieEntry
                {
                    movieID = 3,
                    category = "Action",
                    title = "End Game",
                    year = 2020,
                    director = "Jim Hentsen",
                    rating = "PG-13"
                }
                );
        }
    }
}
