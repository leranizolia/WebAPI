using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Models;
using WebAPI.Data.Repository;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    public class ShopCarController : Controller
    {
        private readonly CarRepository CarRep;

        private readonly ShopCar ShopCar;

        public ShopCarController(CarRepository carRep, ShopCar shopCar)
        {
            ShopCar = shopCar;
            CarRep = carRep;
        }
        //возвращает шаблон
        public ViewResult Index()
        {
            var items = ShopCar.getShopItems();

            ShopCar.ListShopItems = items;

            var obj = new ShopCarViewModel
            {
                ShopCar = ShopCar
            };

            return View(obj);
        }

        //переадресовывает на другую страницу

        public RedirectToActionResult AddToCar (int id)
        {
            var item = CarRep.GetCars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                ShopCar.AddToCar
            }
        }
    }
}
