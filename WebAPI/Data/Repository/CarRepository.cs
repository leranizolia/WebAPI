using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Interfaces;
using WebAPI.Data.Models;

namespace WebAPI.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent AppDBContent;

        public CarRepository(AppDBContent AppDBContent)
        {
            this.AppDBContent = AppDBContent;
        }

        public IEnumerable<Car> GetCars => AppDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => AppDBContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);

        public Car GetCar(int CarId) => AppDBContent.Car.FirstOrDefault(p => p.Id == CarId);
    }
}
