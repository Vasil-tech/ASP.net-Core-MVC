using Microsoft.AspNetCore.Mvc;
using Shop_shop.Data.Interfaces;
using Shop_shop.Data.Models;
using Shop_shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_shop.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllCars carRep;
        private readonly ShopCart shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            this.carRep = carRep;
            this.shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = shopCart.getShopItems();
            shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = this.shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = carRep.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
