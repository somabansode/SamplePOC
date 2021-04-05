using SamplePOC.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePOC.Domain.Messages
{
    public class GetByIdProductResponse : ResponseBase
    {
        public ProductView Product { get; set; }
    }
}
