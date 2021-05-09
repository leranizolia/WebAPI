using System;
using System.Collections.Generic;
using WebAPI.Data.Interfaces;
using WebAPI.Data.Models;

namespace WebAPI.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent AppDBContent;

        public CategoryRepository(AppDBContent AppDBContent)
        {
            this.AppDBContent = AppDBContent;
        }
        public IEnumerable<Category> AllCategories => AppDBContent.Category;
    }

}

