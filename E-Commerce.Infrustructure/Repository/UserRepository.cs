﻿using E_Commerce.Application.Contract;
using E_Commerce.Context;
using E_Commerce_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrustructure.Repository
{
    public class UserRepository:Repository<User,int>, IUserRepository
    {
        E_CommerceContext context;
        public UserRepository(E_CommerceContext _context) : base(_context) { context = _context; }

        public User GetUser(string username, string pass)
        {
           User user = context.Users.FirstOrDefault(c=>c.UserName == username && c.Password == pass );
           
            return user;
        }
    }
}
