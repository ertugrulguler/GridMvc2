using FakeData.DataAccessLayer.Initializer;
using FakeData.Model.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.DataAccessLayer.Context
{
    public class ProjectContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["FakeDataDb"].ConnectionString;
            Database.SetInitializer(new ProjectInitializer());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


    }
}
