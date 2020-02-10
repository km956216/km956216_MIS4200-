using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using km956216_MIS4200.Models;

namespace km956216_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<customer> Customers { get; set; }

        public System.Data.Entity.DbSet<km956216_MIS4200.Models.Vets> Vets { get; set; }

        public System.Data.Entity.DbSet<km956216_MIS4200.Models.Pets> Pets { get; set; }

        // public DbSet<Product> Products { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }

    }    


}