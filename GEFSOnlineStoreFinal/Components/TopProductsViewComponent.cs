using GEFSOnlineStoreFinal.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEFSOnlineStoreFinal.Components
{
    
        public class TopProductsViewComponent : ViewComponent
        {
        private readonly IProductRepository _productRepository;

        public TopProductsViewComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var products = await _productRepository.GetTopProductsAsync(count);
            return View(products);
        }
        }
    
}
