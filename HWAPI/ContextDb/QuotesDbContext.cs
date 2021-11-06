using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HWAPI.ContextDb;
using HWAPI.Models;

namespace HWAPI.ContextDb
{
    public class QuotesDbContext : DbContext
    {
        public DbSet<Quotes> Quotes { get; set; }
        public QuotesDbContext(DbContextOptions<QuotesDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Quotes>().HasData(
                 new Quotes
                 {
                     Id = 1,
                     Text = "Что разум человека может постигнуть и во что он может поверить, того он способен достичь",
                     Author = "Наполеон Хилл",
                     InsertDate = DateTime.ParseExact("15.10.2020", "dd.MM.yyyy", null),
                 },
                    new Quotes
                    {
                        Id = 2,
                        Text = "Стремитесь не к успеху, а к ценностям, которые он дает",
                        Author = "Альберт Эйнштейн",
                        InsertDate = DateTime.ParseExact("02.11.1890", "dd.MM.yyyy", null)
                    },
                    new Quotes
                    {
                        Id = 3,
                        Text = "Надо любить жизнь больше, чем смысл жизни.",
                        Author = "Достоевский",
                        InsertDate = DateTime.ParseExact("06.06.1890", "dd.MM.yyyy", null)
                    },
                    new Quotes
                    {
                        Id = 4,
                        Text = "Сложнее всего начать действовать, все остальное зависит только от упорства",
                        Author = "Амелия Эрхарт",
                        InsertDate = DateTime.ParseExact("25.05.1800", "dd.MM.yyyy", null)
                    },
                    new Quotes
                    {
                        Id = 5,
                        Text = "Начинать всегда стоит с того, что сеет сомнения.",
                        Author = "Борис Стругацкий",
                        InsertDate = DateTime.ParseExact("01.01.1810", "dd.MM.yyyy", null)
                    }
                    );
        }
    }
}
