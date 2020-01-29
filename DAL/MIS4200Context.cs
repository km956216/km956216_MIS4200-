using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using km956216_MIS4200_.Models;

namespace km956216_MIS4200_.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<customer> Customers { get; set; } 

       // public DbSet<Product> Products { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }

    }    


}