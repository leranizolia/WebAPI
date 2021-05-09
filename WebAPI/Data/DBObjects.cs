using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Data.Models;

namespace WebAPI.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый авто",
                        LongDesc = "Красивый, быстрый и тихий авто от компании Tesla",
                        Img = "/img/tesla.jpeg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий авто",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "/img/fiesta.jpeg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "BMV M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "/img/bmv.jpeg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Mercedes C class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "/img/mercedes.jpeg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономный",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "/img/nissan.jpeg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> Category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (Category == null)
                {
                    var list = new Category[]
                    {
                        new Category{CategoryName = "Электромобили", Desc = "Современный вид транспорта"},
                        new Category{CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания"}
                    };

                    Category = new Dictionary<string, Category>();
                    foreach (Category EL in list)
                        Category.Add(EL.CategoryName, EL);
                }

                return Category;
            }
        }
    }
}
