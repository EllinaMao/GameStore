using GameStore.Data;
using GameStore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.ViewComponents
{
    public class TopSellingProductsViewComponent : ViewComponent
    {
        private readonly IProduct _productRepository;

        public TopSellingProductsViewComponent(IProduct productRepository)
        {
            _productRepository = productRepository;
        }

        public IViewComponentResult Invoke(int amount = 10)
        {
            var topProducts = _productRepository.GetTopSellingProducts(amount);
            return View(topProducts);
        }
    }
}

