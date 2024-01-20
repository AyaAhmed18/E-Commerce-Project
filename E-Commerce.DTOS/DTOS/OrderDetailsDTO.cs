﻿using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTOS.DTOS
{
    public class OrderDetailsDTO
    {
        public int Id { get; set; }
        public OrderDTO Order { get; set; }
        public ProductDTO Product { get; set; }
    }
}