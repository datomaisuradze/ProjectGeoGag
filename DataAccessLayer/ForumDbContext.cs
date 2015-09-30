using BusinessLogicLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ForumDbContext:DbContext
    {
        public ForumDbContext() : base("ForumDbContextConnection") { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentReply> CommentReplies{ get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<CommentCommentReply> CommentCommentReplies { get; set; }
    }
}
