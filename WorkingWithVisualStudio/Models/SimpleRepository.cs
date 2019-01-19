using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products
            = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var intialItem = new[]
            {
            new Product { Name = "Kayak", Price= 275m },
            new Product { Name = "LifeJacket" , Price = 48.95m },
            new Product { Name = "Soccer Ball" , Price = 19.50m },
            new Product { Name = "Corner flag" , Price = 34.95m}

        };

            foreach (var p in intialItem)
            {
                AddProduct(p);

            }
            products.Add("Error", null);
        }

        public IEnumerable<Product> Products => products.Values;

        public void AddProduct(Product p) => products.Add(p.Name, p);

    }

}

