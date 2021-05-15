using System;
using WebAPI.Data.Interfaces;
using WebAPI.Data.Models;

namespace WebAPI.Data.Repository
{
    public class OrdersRepository: IAllOrders
    {
        private readonly AppDBContent AppDBContent;

        private readonly ShopCar ShopCar;

        public OrdersRepository (AppDBContent appDBContent, ShopCar shopCar)
        {
            this.AppDBContent = appDBContent;
            this.ShopCar = shopCar;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            //это нужно для того чтобы поместить заказ в базу данных
            AppDBContent.Order.Add(order);

            AppDBContent.SaveChanges();

            var items = ShopCar.ListShopItems;

            foreach (var el in items)
            {
                var OrderDetail = new OrderDetail()
                {
                    CarId = el.Car.Id,
                    OrderId = order.Id,
                    Price = el.Car.Price
                };
                AppDBContent.OrderDetail.Add(OrderDetail);
            };

            AppDBContent.SaveChanges();
        }
    }
}
