using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
         private readonly IProductService _ProductService;
         private readonly ICategoryService _CategoryService;

        public ServiceManager(IProductService productService, ICategoryService categoryService)
        {
            _ProductService = productService;
            _CategoryService = categoryService;
        }

        public IProductService ProductService =>_ProductService;
         public ICategoryService CategoryService =>_CategoryService;
    }
}