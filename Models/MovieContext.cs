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
        public DbSet<mCat> categ { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<mCat>().HasData(
                new mCat
                {
                    categoryID = 1,
                    categoryName = "Action"
                },
                new mCat
                {
                    categoryID = 2,
                    categoryName = "Romance"
                },
                new mCat
                {
                    categoryID = 3,
                    categoryName = "Comedy"
                },
                new mCat
                {
                    categoryID = 4,
                    categoryName = "Horror"
                },
                new mCat
                {
                    categoryID = 5,
                    categoryName = "SciFi"
                },
                new mCat
                {
                    categoryID = 6,
                    categoryName = "Other"
                }
                );
            mb.Entity<movieEntry>().HasData(
                new movieEntry
                {
                    movieID = 1,
                    categoryID = 1,
                    title = "Winter Soilder",
                    year = 2016,
                    director = "Jim Hentsen",
                    rating = "PG-13"
                },
                new movieEntry
                {
                    movieID = 2,
                    categoryID = 1,
                    title = "Civil War",
                    year = 2019,
                    director = "Jim Hentsen",
                    rating = "PG-13"
                },
                new movieEntry
                {
                    movieID = 3,
                    categoryID = 1,
                    title = "End Game",
                    year = 2020,
                    director = "Jim Hentsen",
                    rating = "PG-13"
                }
                );
        }
    }
}
