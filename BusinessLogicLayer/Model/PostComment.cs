using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Model
{
    public class PostComment
    {
        public int PostCommentID { get; set; }
        public int PostID { get; set; }
        public int CommentID { get; set; }
        public DateTime PostCommentDate { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Post Post { get; set; }
    }
}
