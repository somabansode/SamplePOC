using AutoMapper;
using SamplePOC.Domain.ViewModel;
using System.Collections.Generic;

namespace SamplePOC.Domain
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductView>();
            CreateMap<IList<Product>, IList<ProductView>>();
        }
    }
}
