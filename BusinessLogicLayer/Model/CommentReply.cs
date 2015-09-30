using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Model
{
    public class CommentReply
    {
        public CommentReply()
        {
            this.CommentCommentReplies = new HashSet<CommentCommentReply>();
        }

        public int CommentReplyID { get; set; }
        public string CommentReplyText { get; set; }
        public string CommentReplyUser { get; set; }

        public virtual ICollection<CommentCommentReply> CommentCommentReplies { get; set; }
    }
}
