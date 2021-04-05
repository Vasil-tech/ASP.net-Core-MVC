using Microsoft.AspNetCore.Mvc;
using Shop_shop.Data.Interfaces;
using Shop_shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_shop.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars carRep;

        public HomeController(IAllCars carRep)
        {
            this.carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = carRep.GetFavCars
            };
            return View(homeCars);
        }
    }
}
