using SamplePOC.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePOC.Repository
{
    public class SamplePOCDBContext
    {

        public List<Product> Products = new List<Product>();
        public SamplePOCDBContext()
        {
            Products.Add(new Product(101, "ABC", 12540, false));
            Products.Add(new Product(102, "XYZ", 14540, false));
            Products.Add(new Product(103, "ASD", 14520, false));
        }
    }
}
