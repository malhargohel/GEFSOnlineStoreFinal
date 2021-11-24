﻿using GEFSOnlineStoreFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GEFSOnlineStoreFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace GEFSOnlineStoreFinal.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductStoreContext _context = null;

        public CategoryRepository(ProductStoreContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryModel>> GetCategories()
        {
            return await _context.Category.Select(x => new CategoryModel()
            {
                Id = x.Id,
                Description = x.Description,
                Name = x.Name
            }).ToListAsync();
        }
    }
}
