using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCars { get; set; }
        public HomeViewModel()
        {
        }
    }
}
