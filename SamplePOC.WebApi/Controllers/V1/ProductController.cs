using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SamplePOC.Domain.Messages;
using SamplePOC.Domain.Services;
using SamplePOC.Domain.ViewModel;

namespace SamplePOC.WebApi.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private IMapper mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        [HttpGet]
        public GetAllProductResponse GetAll()
        {
            var products = this.productService.GetAll();
            GetAllProductResponse model = new GetAllProductResponse();
            model.Products = mapper.Map<IEnumerable<ProductView>>(products).ToList();
            return model;
        }

        [HttpGet("{id}")]
        public GetByIdProductResponse GetById(int id)
        {
            var products = this.productService.GetById(id);
            GetByIdProductResponse model = new GetByIdProductResponse();
            model.Product = mapper.Map<ProductView>(products);
            return model;
        }
    }
}