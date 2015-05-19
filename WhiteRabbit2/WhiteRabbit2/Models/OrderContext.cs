using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteRabbit2.Models
{
    //You need SqlExpress for working with this database.
    public class OrderContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MyMenu> MyMenu { get; set; }
    }
}
