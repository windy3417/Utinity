namespace DebugUtility.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.user", newName: "UserModles");
            DropPrimaryKey("dbo.UserModles");
            CreateTable(
                "dbo.person",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        pwd = c.String(),
                        EffectDate = c.DateTime(nullable: false),
                        FailuerDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Code);
            
            AddColumn("dbo.UserModles", "userID", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.UserModles", "pwd", c => c.String());
            AddColumn("dbo.UserModles", "RegistrationDate", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.UserModles", "userID");
            DropColumn("dbo.UserModles", "id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserModles", "id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.UserModles");
            DropColumn("dbo.UserModles", "RegistrationDate");
            DropColumn("dbo.UserModles", "pwd");
            DropColumn("dbo.UserModles", "userID");
            DropTable("dbo.person");
            AddPrimaryKey("dbo.UserModles", "id");
            RenameTable(name: "dbo.UserModles", newName: "user");
        }
    }
}
