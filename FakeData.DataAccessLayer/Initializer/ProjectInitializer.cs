using FakeData.DataAccessLayer.Context;
using FakeData.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.DataAccessLayer.Initializer
{
    public class ProjectInitializer : CreateDatabaseIfNotExists<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {

            for (int i = 0; i < 20; i++)
            {
                Category category = new Category
                {
                    Name = FakeData.PlaceData.GetCity(),

                };
                context.Categories.Add(category);
                for (int j = 0; j < 20; j++)
                {
                    Product product = new Product
                    {
                        Category = category,
                        Name = FakeData.PlaceData.GetStreetName(),
                        Price = (decimal)FakeData.NumberData.GetDouble(),
                        Stock = FakeData.NumberData.GetNumber(20, 200),


                    };
                    context.Products.Add(product);

                }

                Customer customer = new Customer
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Age = (byte)FakeData.NumberData.GetNumber(20, 70),
                    Adress = FakeData.PlaceData.GetAddress(),
                    Email = FakeData.NameData.GetFullName() + "@gmail.com",
                    Gender = FakeData.BooleanData.GetBoolean().ToString(),


                };
                context.Customers.Add(customer);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
