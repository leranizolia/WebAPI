using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Data.Models
{
    public class ShopCar
    {
        private readonly AppDBContent AppDBContent;

        public ShopCar(AppDBContent AppDBContent)
        {
            this.AppDBContent = AppDBContent;
        }

        public string ShopCarId { get; set; }

        public List<ShopCarItem> ListShopItems { get; set; }


        //есть ли уже сессия - создана ли корзина? если нет, то создай
        public static ShopCar GetCar(IServiceProvider services)
        {
            //создание новой сессии
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDBContent>();

            string shopCarId = session.GetString("CarId") ?? Guid.NewGuid().ToString();

            session.SetString("CarId", shopCarId);

            return new ShopCar(context) { ShopCarId = shopCarId };
        }

        public void AddToCar(Car car)
        {
            AppDBContent.ShopCarItem.Add(new ShopCarItem
            {
                ShopCarId = ShopCarId,
                Car = car,
                Price = car.Price
            });

            AppDBContent.SaveChanges();
        }

        public List<ShopCarItem> getShopItems()
        {
            return AppDBContent.ShopCarItem.Where(c => c.ShopCarId == ShopCarId).Include(s => s.Car).ToList();
        }
    }
}
