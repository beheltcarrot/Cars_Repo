namespace Cars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Model_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Models", t => t.Model_ID)
                .Index(t => t.Model_ID);
            
            CreateTable(
                "dbo.Manufactures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Manufactures_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Manufactures", t => t.Manufactures_ID)
                .Index(t => t.Manufactures_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "Manufactures_ID", "dbo.Manufactures");
            DropForeignKey("dbo.Cars", "Model_ID", "dbo.Models");
            DropIndex("dbo.Models", new[] { "Manufactures_ID" });
            DropIndex("dbo.Cars", new[] { "Model_ID" });
            DropTable("dbo.Models");
            DropTable("dbo.Manufactures");
            DropTable("dbo.Cars");
        }
    }
}
