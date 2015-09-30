namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommentCommentReplies",
                c => new
                    {
                        CommentCommentReplyID = c.Int(nullable: false, identity: true),
                        CommentID = c.Int(nullable: false),
                        CommentReplyID = c.Int(nullable: false),
                        CommentCommentReplyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentCommentReplyID)
                .ForeignKey("dbo.Comments", t => t.CommentID, cascadeDelete: true)
                .ForeignKey("dbo.CommentReplies", t => t.CommentReplyID, cascadeDelete: true)
                .Index(t => t.CommentID)
                .Index(t => t.CommentReplyID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        CommentUser = c.String(),
                    })
                .PrimaryKey(t => t.CommentID);
            
            CreateTable(
                "dbo.PostComments",
                c => new
                    {
                        PostCommentID = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        CommentID = c.Int(nullable: false),
                        PostCommentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostCommentID)
                .ForeignKey("dbo.Comments", t => t.CommentID, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID)
                .Index(t => t.CommentID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        PostCategory = c.String(),
                        PostName = c.String(),
                        PostText = c.String(),
                        PostUser = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
            CreateTable(
                "dbo.CommentReplies",
                c => new
                    {
                        CommentReplyID = c.Int(nullable: false, identity: true),
                        CommentReplyText = c.String(),
                        CommentReplyUser = c.String(),
                    })
                .PrimaryKey(t => t.CommentReplyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CommentCommentReplies", "CommentReplyID", "dbo.CommentReplies");
            DropForeignKey("dbo.PostComments", "PostID", "dbo.Posts");
            DropForeignKey("dbo.PostComments", "CommentID", "dbo.Comments");
            DropForeignKey("dbo.CommentCommentReplies", "CommentID", "dbo.Comments");
            DropIndex("dbo.PostComments", new[] { "CommentID" });
            DropIndex("dbo.PostComments", new[] { "PostID" });
            DropIndex("dbo.CommentCommentReplies", new[] { "CommentReplyID" });
            DropIndex("dbo.CommentCommentReplies", new[] { "CommentID" });
            DropTable("dbo.CommentReplies");
            DropTable("dbo.Posts");
            DropTable("dbo.PostComments");
            DropTable("dbo.Comments");
            DropTable("dbo.CommentCommentReplies");
        }
    }
}
