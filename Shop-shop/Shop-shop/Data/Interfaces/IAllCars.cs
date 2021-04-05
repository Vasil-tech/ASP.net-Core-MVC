using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_shop.Data.Models;

namespace Shop_shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car GetObjectCar(int CarID);
    }
}
