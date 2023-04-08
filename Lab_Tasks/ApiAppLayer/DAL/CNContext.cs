using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CNContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
    }
}
