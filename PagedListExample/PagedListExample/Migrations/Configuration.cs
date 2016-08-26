namespace MvcApplication8.Migrations
{
    using MvcApplication8.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcApplication8.Models.Ctx>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcApplication8.Models.Ctx context)
        {

            context.Employees.AddOrUpdate(emp => emp.ID,
            new Employee() { FirstName = "Michael", LastName = "Tucker", Salary = 18.00M, Position = "Manager" },
            new Employee() { FirstName = "Morgan", LastName = "Grimes", Salary = 12.00M, Position = "Asst. Manager" },
            new Employee() { FirstName = "Emmett", LastName = "Milbarge", Salary = 14.00M, Position = "Asst. Manager", TerminationDate = DateTime.Parse("1/31/2012") },
            new Employee() { FirstName = "Harry", LastName = "Tang", Salary = 12.00M, Position = "Asst. Manager", TerminationDate = DateTime.Parse("1/31/2011") },
            new Employee() { FirstName = "Diane", LastName = "Beckman", Salary = 22.00M, Position = "Manager" },
            new Employee() { FirstName = "John", LastName = "Casey", Salary = 10.00M, Position = "Green Shirt" },
            new Employee() { FirstName = "Fernando", Salary = 9.00M, Position = "Green Shirt" },
            new Employee() { FirstName = "Bunny", Salary = 9.00M, Position = "Green Shirt" },
            new Employee() { FirstName = "Chuck", LastName = "Bartowski", Salary = 13.00M, Position = "Nerd Herd" },
            new Employee() { FirstName = "Jeffrey", LastName = "Barnes", Salary = 11.25M, Position = "Nerd Herd, Apple" },
            new Employee() { FirstName = "Lester", LastName = "Patel", Salary = 11.25M, Position = "Nerd Herd, Apple" },
            new Employee() { FirstName = "Skip", LastName = "Johnson", Salary = 12.00M, Position = "Nerd Herd" },
            new Employee() { FirstName = "Anna", LastName = "Wu", Salary = 9.00M, Position = "Nerd Herd", TerminationDate = DateTime.Parse("1/31/2012") },
            new Employee() { FirstName = "Hannah", LastName = "", Salary = 8.00M, Position = "Nerd Herd", TerminationDate = DateTime.Parse("1/31/2012") },
            new Employee() { FirstName = "Greta", LastName = "", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2012") },
            new Employee() { FirstName = "Rick", LastName = "Noble", Salary = 8.00M, Position = "Green Shirt" },
            new Employee() { FirstName = "Victoria", LastName = "Dunwoody", Salary = 8.00M, Position = "Green Shirt" },
            new Employee() { FirstName = "Moses", LastName = "Finkelstein", Salary = 180.00M, Position = "Founder" },
            new Employee() { FirstName = "Porter", LastName = "Bauer", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") },
            new Employee() { FirstName = "Marvin", LastName = "Gadsby", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") },
            new Employee() { FirstName = "Cecil", LastName = "Goldenberg", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") },
            new Employee() { FirstName = "Christina", LastName = "James", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") },
            new Employee() { FirstName = "Ruben", LastName = "Mango", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") },
            new Employee() { FirstName = "Sal", LastName = "Sawaya", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") },
            new Employee() { FirstName = "Skye", LastName = "Stoinitz", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") },
            new Employee() { FirstName = "Leticia", LastName = "Williams", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") },
            new Employee() { FirstName = "Sarah", LastName = "Yang", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
            
        }
    }
}
