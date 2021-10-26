namespace DebugUtility.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.person");
            AlterColumn("dbo.person", "Code", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.person", "Code");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.person");
            AlterColumn("dbo.person", "Code", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.person", "Code");
        }
    }
}
