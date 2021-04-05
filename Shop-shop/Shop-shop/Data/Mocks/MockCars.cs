using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_shop.Data.Interfaces;
using Shop_shop.Data.Models;

namespace Shop_shop.Data.Mocks
{
    public class MockCars : IAllCars {

        private readonly ICarCategory _CategoryCars = new MockCategory();
        
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car> {
                    /*new Car {
                        Name = "Tesla",
                        ShortDesc = "То что создал Великий Илон",
                        LongDesc = "Быстрый и бесшумный автомобиль компании Tesla",
                        Img = "/img/Cybertruck.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий автомобиль",
                        LongDesc = "Удобное авто для города",
                        Img = "/img/Ford Fiesta.png",
                        Price = 15000,
                        IsFavorite = false,
                        Aviable = true,
                        Category = _CategoryCars.AllCategories.Last()
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и бандитский",
                        LongDesc = "Удобный автомобиль для понтов",
                        Img = "/img/BMW M3.jpg",
                        Price = 65000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = _CategoryCars.AllCategories.Last()
                    },
                    new Car {
                        Name = "Nissan Leaf",
                        ShortDesc = "Маленький электрокар",
                        LongDesc = "Удобный и малогабаритный",
                        Img = "/img/Nissan Leaf.jpg",
                        Price = 10000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = _CategoryCars.AllCategories.First()
                    }*/
                };
            } 
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int CarID)
        {
            throw new NotImplementedException();
        }
    }
}
