using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Interfaces;
using WebAPI.Data.Models;
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


        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        //ViewResult -> html страница
        public ViewResult List(string category)

        {
            string _category = category;

            IEnumerable<Car> cars = null;

            string currcategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = AllCars.GetCars.OrderBy(i => i.Id);
            }
            else
            {
                //OrdinalIgnoreCase - это для того чтобы был нижний регистр
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = AllCars.GetCars.Where(i => i.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currcategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = AllCars.GetCars.Where(i => i.Category.CategoryName.Equals("Классические автомобили")).OrderBy(i => i.Id);
                    currcategory = "Классические автомобили";
                }

            }

            var CarObj = new CarsListViewModel
            {
                GetAllCars = cars,
                CurrCategory = currcategory
            };

            ViewBag.Title = "Страница с автомобилями";

            return View(CarObj);
        }

    }
}
