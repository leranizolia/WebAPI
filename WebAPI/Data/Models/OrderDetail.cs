using System;
using System.Collections.Generic;

namespace WebAPI.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int CarId { get; set; }

        public decimal Price { get; set; }

        //Почему они virtual?

        public virtual Car Car { get; set; }

        public virtual Order Order { get; set; }

        public OrderDetail()
        {
        }
    }
}
