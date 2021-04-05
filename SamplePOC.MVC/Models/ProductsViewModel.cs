using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePOC.MVC.Models
{
    public class ProductsViewModel : ResponseBase
    {
        public IList<Product> Products { get; set; }
    }
}
