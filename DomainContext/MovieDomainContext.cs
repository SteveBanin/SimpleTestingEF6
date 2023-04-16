using System.Data.Entity;
using TestingEF6CodeFirst.DomainEntities;

namespace TestingEF6CodeFirst.DomainContext
{
    public class MovieDomainContext : DbContext
    {
        public MovieDomainContext() : base("name=MovieDBConnectionString") 
        {
           
        }

        public DbSet<Movie> Movies { get; set; }    

        public DbSet<Producer> Producers { get; set; }

        public DbSet<ProducerAddress> ProducersAddress { get; set; }

    }
}
