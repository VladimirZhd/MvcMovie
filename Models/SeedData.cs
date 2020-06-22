using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-7-24"),
                        GenreId = 1,
                        Rating = "PG",
                        Price = 19.99M,
                        ImageUrl = "https://m.media-amazon.com/images/M/MV5BN2FjNjQzYmMtYmUxOC00YWI3LWJmMDUtNDA5NWYwNDMxNmNhXkEyXkFqcGdeQXVyMzg4MDMyNA@@._V1_.jpg"
                    },

                    new Movie
                    {
                        Title = "Baptists at Our Barbecue",
                        ReleaseDate = DateTime.Parse("2004-10-8"),
                        GenreId = 2,
                        Rating = "PG",
                        Price = 4.99M,
                        ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ4NDU3OTU4NF5BMl5BanBnXkFtZTYwODU2Mjc3._V1_UY1200_CR76,0,630,1200_AL_.jpg"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        GenreId = 2,
                        Rating = "PG",
                        Price = 9.99M,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Poster_of_the_movie_The_Best_Two_Years.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        GenreId = 4,
                        Rating = "PG",
                        Price = 14.99M,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1f/17miracles.jpg/220px-17miracles.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}