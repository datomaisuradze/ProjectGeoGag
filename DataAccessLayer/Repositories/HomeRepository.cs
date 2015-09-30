using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        public ForumDbContext db = new ForumDbContext();

        public IEnumerable<Post> GetPosts
        {
            get
            {
                return db.Posts.ToList();
            }
        }
    }
}
