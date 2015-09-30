using BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class HomeService
    {
        public IHomeRepository HomeRepository { get; set; }

        public HomeService(IHomeRepository homeRepository)
        {
            this.HomeRepository = HomeRepository;
        }
    }
}
