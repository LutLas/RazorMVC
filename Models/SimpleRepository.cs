using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMVC.Models
{
    public class SimpleRepository : IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository;
        public SimpleRepository() {
            var initialItems = new[] {
                new Product { Name = "Kayak", Description="Green Kayak boat for rafting",Category="Water Rafting", Price = 275M },
                new Product { Name = "Lifejacket", Description="Black Life jacket for floating",Category="Water Rafting", Price = 48.95M },
                new Product { Name = "Soccer ball", Description="total 90 sport size 9 football",Category="Soccer", Price = 19.50M },
                new Product { Name = "Corner flag", Description="soccer",Category="yellow corner flag", Price = 34.95M }
            };
            foreach (var p in initialItems) {
                AddProduct(p);
            }
        }
        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
