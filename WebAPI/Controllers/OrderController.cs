using System;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Interfaces;
using WebAPI.Data.Models;

namespace WebAPI.Controllers
{
    public class OrderController: Controller
    {
        private readonly IAllOrders AllOrders;

        private readonly ShopCar ShopCar;

        public OrderController(IAllOrders allOrders, ShopCar shopCar)
        {
            this.AllOrders = allOrders;
            this.ShopCar = shopCar;
        }

        //над этим html шаблоне будут происходить действия, поэтому IActionResult
        //в нашем случае это формочка, куда пользователь будет вводить данные

        public IActionResult Checkout()
        {
            return View();
        }

        //почему эта штука не работает без предыдущего метода?
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            ShopCar.ListShopItems = ShopCar.getShopItems();

            if (ShopCar.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должный быть товары");
            }

            if(ModelState.IsValid)
            {
                AllOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
