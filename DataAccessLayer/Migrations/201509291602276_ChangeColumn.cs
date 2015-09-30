namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "PostContent", c => c.Binary());
            DropColumn("dbo.Posts", "PostText");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "PostText", c => c.String());
            DropColumn("dbo.Posts", "PostContent");
        }
    }
}
