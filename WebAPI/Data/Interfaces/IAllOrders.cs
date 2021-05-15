using System;
using WebAPI.Data.Models;

namespace WebAPI.Data.Interfaces
{
    public interface IAllOrders
    {
        void CreateOrder(Order order);
    }
}
