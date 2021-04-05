using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePOC.Domain.Messages
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
