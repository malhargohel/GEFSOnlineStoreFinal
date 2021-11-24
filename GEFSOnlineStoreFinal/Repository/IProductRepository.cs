﻿using GEFSOnlineStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEFSOnlineStoreFinal.Repository
{
    public interface IProductRepository
    {
        Task<int> AddNewProduct(ProductModel model);
        Task<List<ProductModel>> GetAllProducts();
        Task<ProductModel> GetProductById(int id);
        Task<List<ProductModel>> GetTopProductsAsync(int count);
        List<ProductModel> SearchProduct(string item, string categoryName);
        string GetAppName();
    }
}
