using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using Ecom.Entities;

namespace Ecom.Database
{
   public class EcContext:DbContext
    {
        public EcContext():base("EcomConnection")
        {


        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
