using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePOC.Domain.Contract
{
    public interface IProductRepository
    {
        IList<Product> GetAll();
        Product GetById(int productId);
        void Add(Product product);
    }
}
