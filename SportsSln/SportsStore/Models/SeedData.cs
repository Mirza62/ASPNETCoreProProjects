using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A Boat For One Person",
                        Category = "WaterSports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "LifeJacket",
                        Description = "Protective and Fashionable",
                        Category = "WaterSports",
                        Price = 48.95M
                    },
                    new Product
                    {
                        Name = "SoccerBall",
                        Description = "Fifa-Approved Size and Weight",
                        Category = "Soccer",
                        Price = 19.50M
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Giving your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95M
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "Flat-Packed 35,000 Seat Stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess",
                        Price = 16
                    }, new Product
                    {
                        Name = "UnSteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95M
                    },
                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "A fun Game for the family",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-Plated,Diamond-Studded King",
                        Category = "Chess",
                        Price = 1200
                    });
                context.SaveChanges();
            }
        }
    }
}
