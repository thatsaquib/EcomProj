using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomProj.Repository.EF
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("MyConnSt")
        {
        }

        public System.Data.Entity.DbSet<EcomProj.Model.Product> Products { get; set; }

        public System.Data.Entity.DbSet<EcomProj.Model.Category> Categories { get; set; }
    }
}
