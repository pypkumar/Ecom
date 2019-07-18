using Ecom.Database;
using Ecom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Services
{
   public class CategoriesService
    {
        public Category GetCategories(int ID)
        {
            using (var Context = new EcContext())
            {
                return Context.Categories.Find(ID);


            }
        }
        public List<Category> GetCategories()
        {
            using (var Context = new EcContext())
            {
                return Context.Categories.ToList();


            }
        }
        public void SaveCategory(Category category)
        {
            using (var Context = new EcContext())
            {
                Context.Categories.Add(category);
                Context.SaveChanges();


            }
        }
        public void UpdateCategory(Category category)
        {
            using (var Context = new EcContext())
            {
                Context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();


            }
        }
        public void DeleteCategory(int ID)
        {
            using (var Context = new EcContext())
            {
                var category = Context.Categories.Find(ID);
                //Context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                Context.Categories.Remove(category);
                Context.SaveChanges();


            }
        }
    }
}
