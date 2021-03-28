namespace debugUtility.Migrations
{
    extern alias EF;
    using System;
    using EF::System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.user",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.user");
        }
    }
}
