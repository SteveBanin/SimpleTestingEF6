using System;
using TestingEF6CodeFirst.DomainContext;
using TestingEF6CodeFirst.DomainEntities;

namespace TestingEF6CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new MovieDomainContext())
            {
               var movie = new Movie
               {
                  MovieTitle = "Hunter Killer",
                  MovieCategory = "Action"
               };
                ctx.Movies.Add(movie);
                ctx.SaveChanges();
            }
            Console.WriteLine("Testing completed.");
            Console.ReadLine();

        }

    }
}
