namespace LivrariaApp.Migrations
{
    using LivrariaApp.Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LivrariaApp.Models.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LivrariaApp.Models.BookDBContext context)
        {
            if (context.Book.Any())
            {
                // DB already seeded
                return;
            }
            context.Book.AddOrUpdate(i => i.ISBN,
                new Book
                {
                    ISBN = 9781726401296,
                    Title = "Dom Casmurro",
                    Author = "Joaquim Machado de Assis",
                    Genre = "Romance",
                    Price = 7.99M,
                    Stock = 10
                },
                new Book
                {
                    ISBN = 9780544338012,
                    Title = "Silmarillion",
                    Author = "J.R.R. Tolkien",
                    Genre = "Fantasia",
                    Price = 9.99M,
                    Stock = 4
                },
                new Book
                {
                    ISBN = 9780451208637,
                    Title = "Divina Comédia",
                    Author = "Dante Alighieri",
                    Genre = "Fantasia",
                    Price = 14.99M,
                    Stock = 7
                }
            );
        }
    }
}
