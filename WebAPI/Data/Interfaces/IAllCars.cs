using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> GetCars { get; }

        IEnumerable<Car> GetFavCars { get; }

        Car GetCar(int CarId);

    }
}
