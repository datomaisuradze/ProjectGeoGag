﻿using BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class AdminService
    {
        public IAdminRepository AdminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            this.AdminRepository = adminRepository;
        }
    }
}
