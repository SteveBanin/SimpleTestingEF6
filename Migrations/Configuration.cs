namespace TestingEF6CodeFirst.Migrations
{
    using System.Data.Entity.Migrations;
 
    internal sealed class Configuration : DbMigrationsConfiguration<TestingEF6CodeFirst.DomainContext.MovieDomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestingEF6CodeFirst.DomainContext.MovieDomainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
