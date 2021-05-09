using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Data.Interfaces;
using WebAPI.Data.Models;

namespace WebAPI.Data.Mocks
{
    public class MockCars: IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();

        public IEnumerable<Car> GetCars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый авто",
                        LongDesc = "Красивый, быстрый и тихий авто от компании Tesla",
                        Img = "/img/tesla.jpeg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.First()
                 },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий авто",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "/img/fiesta.jpeg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = categoryCars.AllCategories.Last()
                 },
                    new Car {
                        Name = "BMV M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "/img/bmv.jpeg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.Last()
                 },
                    new Car {
                        Name = "Mercedes C class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "/img/mercedes.jpeg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = categoryCars.AllCategories.Last()
                 },
                    new Car {
                        Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономный",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "/img/nissan.jpeg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.First()
                 }
            };
        }
    }
        public IEnumerable<Car> GetFavCars { get ; set ; }

        public Car GetCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
