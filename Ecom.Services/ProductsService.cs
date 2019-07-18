using Ecom.Database;
using Ecom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Services
{
   public class ProductsService
    {
        public Product GetProducts(int ID)
        {
            using (var Context = new EcContext())
            {
                return Context.products.Find(ID);


            }
        }
        public List<Product> GetProducts()
        {
            using (var Context = new EcContext())
            {
                return Context.products.ToList();


            }
        }
        public void SaveProduct(Product product)
        {
            using (var Context = new EcContext())
            {
                Context.products.Add(product);
                Context.SaveChanges();


            }
        }
        public void UpdateProduct(Product product)
        {
            using (var Context = new EcContext())
            {
                Context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();


            }
        }
        public void DeleteProduct(int ID)
        {
            using (var Context = new EcContext())
            {
                var product= Context.products.Find(ID);
                //Context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                Context.products.Remove(product);
                Context.SaveChanges();


            }
        }
    }
}
