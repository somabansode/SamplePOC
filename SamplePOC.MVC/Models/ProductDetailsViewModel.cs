using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePOC.MVC.Models
{
    public class ProductDetailsViewModel : ResponseBase
    {
        public Product Product { get; set; }
    }
}
