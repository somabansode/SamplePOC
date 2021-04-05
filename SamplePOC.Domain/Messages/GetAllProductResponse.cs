using SamplePOC.Domain.ViewModel;
using System.Collections.Generic;

namespace SamplePOC.Domain.Messages
{
    public class GetAllProductResponse : ResponseBase
    {
        public IList<ProductView> Products { get; set; }
    }
}
