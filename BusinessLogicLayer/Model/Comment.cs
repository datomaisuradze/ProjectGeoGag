using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Model
{
    public class Comment
    {
        public Comment()
        {
            this.PostComments = new HashSet<PostComment>();
            this.CommentCommentReplies = new HashSet<CommentCommentReply>();
        }
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public string CommentUser { get; set; }

        public virtual ICollection<CommentCommentReply> CommentCommentReplies { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; }
    }
}
