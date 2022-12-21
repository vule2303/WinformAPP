using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Web_Eshop.Models
{
    public class Cricketer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ODI { get; set; }
        public string Test { get; set; }

    }
    public class CricketerDBContext : DbContext
    {
        public DbSet<Cricketer> Cricketers { get; set; }
    }
}