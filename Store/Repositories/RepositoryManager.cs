using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _contex;
        private readonly IProductRepository _productRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext contex)
        {
            _productRepository = productRepository;
            _contex = contex;
        }

        public IProductRepository Product => _productRepository;

        public void Save()
        {
            _contex.SaveChanges();
        }
    }
}