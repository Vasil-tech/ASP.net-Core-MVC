﻿using Shop_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_shop.Data.Interfaces
{
    public interface IAllOrders
    {
        void CreateOrder(Order order); 
    }
}
