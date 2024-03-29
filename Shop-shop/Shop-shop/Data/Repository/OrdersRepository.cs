﻿using Shop_shop.Data.Interfaces;
using Shop_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach (var el in items)
            {
                var OrderDetail = new OrderDetail()
                {
                    CarID = el.Car.Id,
                    OrderID = order.Id,
                    Price = el.Car.Price
                };
                appDBContent.OrderDetail.Add(OrderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
