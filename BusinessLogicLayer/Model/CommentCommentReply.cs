using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Model
{
    public class CommentCommentReply
    {
        public int CommentCommentReplyID { get; set; }
        public int CommentID { get; set; }
        public int CommentReplyID { get; set; }
        public System.DateTime CommentCommentReplyDate { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual CommentReply CommentReply { get; set; }
    }
}
