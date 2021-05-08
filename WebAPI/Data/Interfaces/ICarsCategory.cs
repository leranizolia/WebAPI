using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
