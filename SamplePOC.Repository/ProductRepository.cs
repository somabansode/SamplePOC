
using SamplePOC.Domain;
using SamplePOC.Domain.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamplePOC.Repository
{
    public class ProductRepository : IProductRepository
    {
        //CreatedStatic sample context with hardcoded ata
        public SamplePOCDBContext dbContext;
        public ProductRepository(SamplePOCDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IList<Product> GetAll()
        {
            return this.dbContext.Products.ToList();
        }

        public Product GetById(int productId)
        {
            return this.dbContext.Products.FirstOrDefault(prod => prod.ProductId == productId);
        }

        public void Add(Product product)
        {
            this.dbContext.Products.Add(product);
        }

    }
}
