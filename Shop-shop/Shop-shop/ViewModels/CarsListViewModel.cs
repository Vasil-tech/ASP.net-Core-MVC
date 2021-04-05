using Shop_shop.Data.Models;
using System.Collections.Generic;

namespace Shop_shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string carCategory { get; set; }
    }
}
