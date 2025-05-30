﻿using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Migrations;
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
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M

                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "Inception",
                        ReleaseDate = DateTime.Parse("2010-7-16"),
                        Genre = "Action",
                        Rating = "R",
                        Price = 9.99M
                    },
                    new Movie
                    {
                    Title = "The Matrix",
                        ReleaseDate = DateTime.Parse("1999-3-31"),
                        Genre = "Science Fiction",
                        Rating = "R",
                        Price = 8.99M
                    },
                    new Movie
                    {
                    Title = "Interstellar",
                        ReleaseDate = DateTime.Parse("2014-11-7"),
                        Genre = "Science Fiction",
                        Rating = "R",
                        Price = 10.99M
                    },
                    new Movie
                    {
                    Title = "Parasite",
                        ReleaseDate = DateTime.Parse("2019-5-30"),
                        Genre = "Drama",
                        Rating = "R",
                        Price = 7.99M
                    },
                    new Movie
                    {
                    Title = "Spirited Away",
                        ReleaseDate = DateTime.Parse("2001-7-20"),
                        Genre = "Animation",
                        Rating = "PG-13",
                        Price = 6.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
