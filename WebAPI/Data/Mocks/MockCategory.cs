using System;
using System.Collections.Generic;
using WebAPI.Data.Interfaces;
using WebAPI.Data.Models;

namespace WebAPI.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "электромобили", Desc = "современный вид транспорта"},
                    new Category{CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
