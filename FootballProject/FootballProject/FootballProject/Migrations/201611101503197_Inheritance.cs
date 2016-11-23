namespace FootballProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inheritance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FootballTeams",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NameOfTheTeam = c.String(nullable: false),
                        YearFound = c.Int(nullable: false),
                        Stadium = c.String(),
                        Owner = c.String(nullable: false),
                        Coach = c.String(),
                        Website = c.String(),
                        Name = c.String(maxLength: 60),
                        Birthday = c.DateTime(),
                        IdNumber = c.Long(),
                        BornCity = c.String(maxLength: 60),
                        UniqueNumber = c.Int(),
                        Height = c.Double(),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FootballTeams");
        }
    }
}
