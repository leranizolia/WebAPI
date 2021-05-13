using System;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Interfaces;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    public class HomeController: Controller
    {
        private IAllCars CarRep;

        public HomeController(IAllCars carRep)
        {
            CarRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = CarRep.GetFavCars
            };
            //пусть на главной странице только любимые товары отражены
            return View(homeCars);
        }
    }
}
