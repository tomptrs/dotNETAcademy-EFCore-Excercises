using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class DbInitializer
    {

        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            if (context.Movies.Any())
            {
                return;
            }

            context.Ratings.AddRange(
                new Rating {  Code="G", Name="General"},
                new Rating { Code = "PG", Name = "Parental Guidance" },
                new Rating { Code = "M", Name = "Mature" }
                );
            context.SaveChanges();


            context.Movies.AddRange(
                new Movie
                {
                     Title="When Harry met Sally",
                      ReleaseDate=DateTime.Parse("1989-1-11"),
                       Genre = "Romatic Comedy",
                        Price=8,
                         RatingId=1
                },
                  new Movie
                  {
                      Title = "Ghostbusters",
                      ReleaseDate = DateTime.Parse("1984-3-13"),
                      Genre = "Comedy",
                      Price = 9,
                      RatingId = 1
                  },
                    new Movie
                    {
                        Title = "Ghostbusters2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9,
                        RatingId = 1
                    },
                     new Movie
                     {
                         Title = "Indiana Jones",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "thriller",
                         Price = 9,
                         RatingId = 3
                     },
                    new Movie
                    {
                        Title = "Top Gun",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Action",
                        Price = 11,
                        RatingId = 2
                    },
                     new Movie
                     {
                         Title = "Lord of the rings",
                         ReleaseDate = DateTime.Parse("2010-2-23"),
                         Genre = "Science Fiction",
                         Price = 10,
                         RatingId = 2
                     },
                     new Movie
                     {
                         Title = "Star Wars",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "thriller",
                         Price = 10,
                         RatingId = 3
                     },
                    new Movie
                    {
                        Title = "Lion King",
                        ReleaseDate = DateTime.Parse("1999-2-23"),
                        Genre = "Kids",
                        Price = 11,
                        RatingId = 1
                    },
                    new Movie
                    {
                        Title = "Rambo",
                        ReleaseDate = DateTime.Parse("1999-2-23"),
                        Genre = "Action",
                        Price = 11,
                        RatingId = 2
                    },
                    new Movie
                    {
                        Title = "Rocky 3",
                        ReleaseDate = DateTime.Parse("1999-2-23"),
                        Genre = "Action",
                        Price = 11,
                        RatingId = 2
                    },
                    new Movie
                    {
                        Title = "Liar liar",
                        ReleaseDate = DateTime.Parse("1999-2-23"),
                        Genre = "Comedy",
                        Price = 8,
                        RatingId = 1
                    }

                );
            context.SaveChanges();

        }
    }
}
