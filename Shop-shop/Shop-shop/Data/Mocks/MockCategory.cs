using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_shop.Data.Interfaces;
using Shop_shop.Data.Models;

namespace Shop_shop.Data.Mocks
{
    public class MockCategory : ICarCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>
                {
                    new Category {CategoryName = "Электромобили", Desc = "Современный вид транспорта" },
                    new Category { CategoryName = "Классические авто", Desc = "Машины с ДВС"}
                };
            }
        }
    }
}
