using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class HomeService
    {
        public IHomeRepository HomeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            this.HomeRepository = homeRepository;
        }

        public IEnumerable<Post> GetPosts
        {
            get
            {
                return HomeRepository.GetPosts;
            }
        }
    }
}
