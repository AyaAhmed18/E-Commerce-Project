﻿using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contract
{
    public interface IUserRepository:Irepository<User,int>
    {
      public User GetUser(string username , string password);
    }
}
