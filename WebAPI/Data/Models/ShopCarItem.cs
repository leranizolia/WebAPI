﻿using System;
namespace WebAPI.Data.Models
{
    public class ShopCarItem
    {
        public int Id { get; set; }

        public virtual Car Car { get; set; }

        public decimal Price { get; set; }

        public string ShopCarId { get; set; }

    }
}

