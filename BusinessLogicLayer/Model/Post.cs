using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLogicLayer.Model
{
    public class Post
    {
        public Post()
        {
            this.PostComments = new HashSet<PostComment>();
        }

        public int PostID { get; set; }
        public string PostCategory { get; set; }
        public string PostName { get; set; }
        public byte[] PostContent { get; set; }
        public string PostUser{ get; set; }

        public virtual ICollection<PostComment> PostComments { get; set; }
    }
}
