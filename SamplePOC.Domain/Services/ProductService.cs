using SamplePOC.Domain.Contract;
using System.Collections.Generic;

namespace SamplePOC.Domain.Services
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IList<Product> GetAll()
        {
            return this.productRepository.GetAll();
        }

        public Product GetById(int productId)
        {
            return this.productRepository.GetById(productId);
        }
    }
}
