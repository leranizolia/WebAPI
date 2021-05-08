using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }

        public string CurrCategory { get; set; }
    }
}

