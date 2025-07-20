using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
           products.Add(new Product {IdProduct = 1, Name = "Um", Price = 10 });
           products.Add(new Product { IdProduct = 2, Name = "Dois", Price = 200 });
           products.Add(new Product { IdProduct = 3, Name = "Três", Price = 30 });
           products.Add(new Product { IdProduct = 4, Name = "Quatro ", Price = 40 });
           products.Add(new Product { IdProduct = 5, Name = "Cinco", Price = 50 });
            return products;
        }

        public bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePrduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
