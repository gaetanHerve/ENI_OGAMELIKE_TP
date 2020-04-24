namespace OGAME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Planets", "Name", c => c.String(maxLength: 20));
            AlterColumn("dbo.Buildings", "Name", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Buildings", "Name", c => c.String());
            AlterColumn("dbo.Planets", "Name", c => c.String());
        }
    }
}
