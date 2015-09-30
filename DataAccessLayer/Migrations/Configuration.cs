namespace DataAccessLayer.Migrations
{
    using BusinessLogicLayer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.ForumDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.ForumDbContext context)
        {
            //context.Posts.AddOrUpdate(x => x.PostID,
            //    new Post { PostID = 1, PostCategory = "Science and education", PostName = "This Forum", PostText = "What do you think about this forum?", PostUser = "Dato Maisuradze" });

            //context.Comments.AddOrUpdate(x => x.CommentID,
            //    new Comment { CommentID = 1, CommentText = "It's awesome", CommentUser = "Dato Maisuradze" },
            //    new Comment { CommentID = 2, CommentText = "It's great", CommentUser = "Dato Maisuradze" },
            //    new Comment { CommentID = 3, CommentText = "It's nice", CommentUser = "Dato Maisuradze" }
            //    );

            //context.CommentReplies.AddOrUpdate(x => x.CommentReplyID,
            //    new CommentReply { CommentReplyID = 1, CommentReplyText = "I agree", CommentReplyUser = "Dato Maisuradze" },
            //    new CommentReply { CommentReplyID = 2, CommentReplyText = "Of cource", CommentReplyUser = "Dato Maisuradze" },
            //    new CommentReply { CommentReplyID = 3, CommentReplyText = "You're right", CommentReplyUser = "Dato Maisuradze" }
            //    );

            //context.PostComments.AddOrUpdate(x => x.PostCommentID,
            //    new PostComment { PostCommentID = 1, PostID = 1, CommentID = 1, PostCommentDate = DateTime.Now },
            //    new PostComment { PostCommentID = 2, PostID = 1, CommentID = 2, PostCommentDate = DateTime.Now },
            //    new PostComment { PostCommentID = 3, PostID = 1, CommentID = 3, PostCommentDate = DateTime.Now }
            //    );

            //context.CommentCommentReplies.AddOrUpdate(x => x.CommentCommentReplyID,
            //    new CommentCommentReply { CommentCommentReplyID = 1, CommentID = 1, CommentReplyID = 1, CommentCommentReplyDate = DateTime.Now },
            //    new CommentCommentReply { CommentCommentReplyID = 2, CommentID = 1, CommentReplyID = 2, CommentCommentReplyDate = DateTime.Now },
            //    new CommentCommentReply { CommentCommentReplyID = 3, CommentID = 1, CommentReplyID = 3, CommentCommentReplyDate = DateTime.Now }
            //    );
        }

        //This method will be called after migrating to the latest version.

        //You can use the DbSet<T>.AddOrUpdate() helper extension method
        //to avoid creating duplicate seed data.E.g.

        //  context.People.AddOrUpdate(
        //    p => p.FullName,
        //    new Person { FullName = "Andrew Peters" },
        //    new Person { FullName = "Brice Lambson" },
        //    new Person { FullName = "Rowan Miller" }
        //  );

    }
}
