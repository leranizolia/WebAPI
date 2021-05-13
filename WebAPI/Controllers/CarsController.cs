using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Interfaces;
using WebAPI.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    public class CarsController : Controller
    {
        //Мы можем так делать, потому что мы в конфиге прописали
        //связь между интерфейсом и его реализацией (т. е. по сути при
        //обращении к интерфейсу сразу подтягивается его реализация)
        private readonly IAllCars AllCars;
        private readonly ICarsCategory AllCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            AllCars = iAllCars;
            AllCategories = iCarsCategory;
        }

        //ViewResult -> html страница
        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel
            {
                GetAllCars = AllCars.GetCars,

                CurrCategory = "Автомобили"
            };

            return View(obj);
        }

    }
}
