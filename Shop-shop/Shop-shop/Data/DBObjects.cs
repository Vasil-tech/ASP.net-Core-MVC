using System;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Shop_shop.Data.Models;

namespace Shop_shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content) 
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange
                (
                    new Car
                    {
                        Name = "Tesla",
                        ShortDesc = "То что создал Великий Илон",
                        LongDesc = "Быстрый и бесшумный автомобиль компании Tesla",
                        Img = "/img/Cybertruck.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий автомобиль",
                        LongDesc = "Удобное авто для города",
                        Img = "/img/Ford Fiesta.png",
                        Price = 15000,
                        IsFavorite = false,
                        Aviable = true,
                        Category = Categories["Классические авто"]
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и бандитский",
                        LongDesc = "Удобный автомобиль для понтов",
                        Img = "/img/BMW M3.jpg",
                        Price = 65000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = Categories["Классические авто"]
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "Маленький электрокар",
                        LongDesc = "Удобный и малогабаритный",
                        Img = "/img/Nissan Leaf.jpg",
                        Price = 10000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Roadster",
                        ShortDesc = "Четырехместный суперкар",
                        LongDesc = "Удобный и малогабаритный",
                        Img = "/img/Roadster.png",
                        Price = 65000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Semi",
                        ShortDesc = "Электро грузовик",
                        LongDesc = "Большой и многообещающий",
                        Img = "/img/Semi.png",
                        Price = 60000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Model S Plaid Plus",
                        ShortDesc = "Маленький электрокар",
                        LongDesc = "Самая нестандартная версия седана",
                        Img = "/img/Model S Plaid Plus.png",
                        Price = 50000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Cyberquad",
                        ShortDesc = "Электрический квадроцикл",
                        LongDesc = "Приятное дополнение к Cybertruck",
                        Img = "/img/Cyberquad.png",
                        Price = 5000,
                        IsFavorite = true,
                        Aviable = true,
                        Category = Categories["Электромобили"]
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get 
            {
                if (category == null) 
                {
                    var list = new Category[]
                        {
                            new Category {CategoryName = "Электромобили", Desc = "Современный вид транспорта" },
                            new Category { CategoryName = "Классические авто", Desc = "Машины с ДВС"}
                        };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);
                }
                return category;
            }
        }
    }
}
