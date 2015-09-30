namespace ProjectForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRegisterUsername1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RegisterUsername", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RegisterUsername");
        }
    }
}
