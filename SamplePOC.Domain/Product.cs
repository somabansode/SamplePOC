
namespace SamplePOC.Domain
{
    public class Product
    {
        public Product(int productId, string name, decimal price, bool status)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Price = price;
            this.Status = status;
        }

        public int ProductId { get; set; }
        
        public string Name { get; set; }
        
        public decimal Price { get; set; }

        public bool Status { get; set; }

    }
}
