namespace OGAME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "SolarSystem_Id", c => c.Long());
            AddColumn("dbo.Resources", "Building_Id", c => c.Long());
            AddColumn("dbo.Resources", "Building_Id1", c => c.Long());
            AddColumn("dbo.Resources", "ResourceGenerator_Id", c => c.Long());
            CreateIndex("dbo.Buildings", "SolarSystem_Id");
            CreateIndex("dbo.Resources", "Building_Id");
            CreateIndex("dbo.Resources", "Building_Id1");
            CreateIndex("dbo.Resources", "ResourceGenerator_Id");
            AddForeignKey("dbo.Resources", "Building_Id", "dbo.Buildings", "Id");
            AddForeignKey("dbo.Resources", "Building_Id1", "dbo.Buildings", "Id");
            AddForeignKey("dbo.Resources", "ResourceGenerator_Id", "dbo.Buildings", "Id");
            AddForeignKey("dbo.Buildings", "SolarSystem_Id", "dbo.SolarSystems", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buildings", "SolarSystem_Id", "dbo.SolarSystems");
            DropForeignKey("dbo.Resources", "ResourceGenerator_Id", "dbo.Buildings");
            DropForeignKey("dbo.Resources", "Building_Id1", "dbo.Buildings");
            DropForeignKey("dbo.Resources", "Building_Id", "dbo.Buildings");
            DropIndex("dbo.Resources", new[] { "ResourceGenerator_Id" });
            DropIndex("dbo.Resources", new[] { "Building_Id1" });
            DropIndex("dbo.Resources", new[] { "Building_Id" });
            DropIndex("dbo.Buildings", new[] { "SolarSystem_Id" });
            DropColumn("dbo.Resources", "ResourceGenerator_Id");
            DropColumn("dbo.Resources", "Building_Id1");
            DropColumn("dbo.Resources", "Building_Id");
            DropColumn("dbo.Buildings", "SolarSystem_Id");
        }
    }
}
