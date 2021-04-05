using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePOC.Domain.Services
{
    public interface IProductService
    {
        IList<Product> GetAll();
        Product GetById(int productId);

        //void Add(Product product);
    }
}
