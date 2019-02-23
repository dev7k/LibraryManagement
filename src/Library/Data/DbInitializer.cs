using Library.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Library.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LibraryDbContext>();

                // Add Customers
                var john = new Customer { Name = "John Snow" };
                var mark = new Customer { Name = "Mark Smith" };
                var jason = new Customer { Name = "Jason Bourne" };

                context.Customers.Add(john);
                context.Customers.Add(mark);
                context.Customers.Add(jason);

                // Add Author
                var authorBrett = new Author
                {
                    Name = "Peter V. Brett",
                    Books = new List<Book>()
                {
                    new Book { Title = "The Painted Man" },
                    new Book { Title = "The Desert Spear" }
                }
                };

                var authorKing = new Author
                {
                    Name = "Stephen King",
                    Books = new List<Book>()
                {
                    new Book { Title = "Misery"},
                    new Book { Title = "The Green Mile"},
                    new Book { Title = "Mr. Mercedes"}
                }
                };

                var authorMartin = new Author
                {
                    Name = "Robert C. Martin",
                    Books = new List<Book>()
                {
                    new Book { Title = "Clean Code"},
                    new Book { Title = "Clean Architecture"},
                }
                };

                context.Authors.Add(authorBrett);
                context.Authors.Add(authorKing);
                context.Authors.Add(authorMartin);

                context.SaveChanges();
            }
        }
    }
}
