﻿namespace BookStore.Migrations
{
    using BookStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Models.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BookStore.Models.BooksDBContext";
        }

        protected override void Seed(BookStore.Models.BookDBContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Book.AddOrUpdate(i => i.BookName,
                new Book
                {
                    Id = "9b0896fa-3880-4c2e-bfd6-925c87f22878",
                    BookName = "CQRS For Dummies",
                    Reserved = false
                },
                new Book
                {
                    Id = "0550818d-36ad-4a8d-9c3a-a715bf15de76",
                    BookName = "Visual Studio Tips",
                    Reserved = false
                },
                new Book
                {
                    Id = "8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1",
                    BookName = "NHibernate Cookbook",
                    Reserved = false
                }
                ); ;
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
