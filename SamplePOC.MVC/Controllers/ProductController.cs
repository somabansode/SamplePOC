using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamplePOC.MVC.Models;

namespace SamplePOC.MVC.Controllers
{
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            string apiUrl = "http://localhost:62619/api/v1/product";

            var products = new List<Product>();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var table = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductsViewModel>(data);
                    products = table.Products.ToList();
                }

            }
            return View(products);
        }

        public async Task<IActionResult> Details(int id)
        {
            string apiUrl = "http://localhost:62619/api/v1/product/"+id;

            var productDetails = new Product();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var table = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDetailsViewModel>(data);
                    productDetails = table.Product;
                }
            }
            return View(productDetails);
        }
    }
}