using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
           
        }

        public IQueryable<Product> GetdAllProducts(bool trackChanges)=>FindAll(trackChanges);
      
    }
}