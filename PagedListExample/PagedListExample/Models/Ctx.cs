using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication8.Models
{
    public class Ctx : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}