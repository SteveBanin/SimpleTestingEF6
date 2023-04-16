namespace TestingEF6CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieDB_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieTitle = c.String(),
                        MovieCategory = c.String(),
                        MovieRelaesedDate = c.DateTime(),
                        MovieDuration = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProducerAddresses",
                c => new
                    {
                        ProducerAddressId = c.Int(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Zipcode = c.Int(nullable: false),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.ProducerAddressId)
                .ForeignKey("dbo.Producers", t => t.ProducerAddressId)
                .Index(t => t.ProducerAddressId);
            
            CreateTable(
                "dbo.ProducerMovies",
                c => new
                    {
                        Producer_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producer_Id, t.Movie_Id })
                .ForeignKey("dbo.Producers", t => t.Producer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Producer_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProducerMovies", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.ProducerMovies", "Producer_Id", "dbo.Producers");
            DropForeignKey("dbo.ProducerAddresses", "ProducerAddressId", "dbo.Producers");
            DropIndex("dbo.ProducerMovies", new[] { "Movie_Id" });
            DropIndex("dbo.ProducerMovies", new[] { "Producer_Id" });
            DropIndex("dbo.ProducerAddresses", new[] { "ProducerAddressId" });
            DropTable("dbo.ProducerMovies");
            DropTable("dbo.ProducerAddresses");
            DropTable("dbo.Producers");
            DropTable("dbo.Movies");
        }
    }
}
