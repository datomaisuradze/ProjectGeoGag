namespace ProjectForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToDeleteSomething : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.something",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        register_Firstname = c.String(nullable: false),
                        register_Lastname = c.String(nullable: false),
                        register_RegisterUsername = c.String(nullable: false),
                        register_Email = c.String(nullable: false),
                        register_Password = c.String(nullable: false, maxLength: 100),
                        register_ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
