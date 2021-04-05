using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_shop.Data.Interfaces;
using Shop_shop.Data.Models;
using Shop_shop.ViewModels;

namespace Shop_shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _AllCars;
        private readonly ICarCategory _AllCategories;

        public CarsController(IAllCars iAllCars, ICarCategory iCarCat)
        {
            _AllCars = iAllCars;
            _AllCategories = iCarCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _AllCars.Cars.OrderBy(i => i.Id);
            }
            else {
                if (string.Equals("Electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _AllCars.Cars.Where(i => i.Category.CategoryName.Equals("Электромобили"));
                    currCategory = "Электромобили";
                }
                else if (string.Equals("Fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _AllCars.Cars.Where(i => i.Category.CategoryName.Equals("Классические авто"));
                    currCategory = "Классические авто";
                }
                
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                carCategory = currCategory
            };
            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);
        }
    }
}
