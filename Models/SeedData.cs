using Gurdeep_Fork_Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Gurdeep_Fork_Assignment.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ForkContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ForkContext>>()))
            {
                // Look for any movies.
                if (context.Fork.Any())
                {
                    return;   // DB has been seeded
                }


                context.Fork.AddRange(
                    new Fork
                    {
                        Brand = "Exotic Co.",
                        Model = "Model 3",
                        PurchaseDate = DateTime.Parse("2023-03-10"),
                        Price = 15.99M,
                        HandleMaterial = "Wood",
                        TineCount = 2,
                        Rating = RateScale.One
                    },
                    new Fork
                    {
                        Brand = "Popular Fork Co.",
                        Model = "Deluxe Fork",
                        PurchaseDate = DateTime.Parse("2023-04-05"),
                        Price = 39.99M,
                        HandleMaterial = "Metal",
                        TineCount = 4,
                        Rating = RateScale.Five
                    },
                    new Fork
                    {
                        Brand = "Everyday Forks",
                        Model = "Standard Fork",
                        PurchaseDate = DateTime.Parse("2023-05-20"),
                        Price = 9.99M,
                        HandleMaterial = "Plastic",
                        TineCount = 3,
                        Rating = RateScale.Two
                    },
                    new Fork
                    {
                        Brand = "Premium Forkworks",
                        Model = "Elegant Fork",
                        PurchaseDate = DateTime.Parse("2023-06-15"),
                        Price = 29.99M,
                        HandleMaterial = "Silver",
                        TineCount = 4,
                        Rating = RateScale.Four
                    },
                    new Fork
                    {
                        Brand = "Affordable Forks Ltd.",
                        Model = "Econo Fork",
                        PurchaseDate = DateTime.Parse("2023-07-08"),
                        Price = 7.99M,
                        HandleMaterial = "Plastic",
                        TineCount = 2,
                        Rating = RateScale.One
                    },
                    new Fork
                    {
                        Brand = "Gourmet Forkware",
                        Model = "Gourmet Fork",
                        PurchaseDate = DateTime.Parse("2023-08-25"),
                        Price = 49.99M,
                        HandleMaterial = "Wood",
                        TineCount = 4,
                        Rating = RateScale.Five
                    },
                    new Fork
                    {
                        Brand = "Modern Dining Solutions",
                        Model = "Sleek Fork",
                        PurchaseDate = DateTime.Parse("2023-09-12"),
                        Price = 19.99M,
                        HandleMaterial = "Metal",
                        TineCount = 3,
                        Rating = RateScale.Three
                    },
                    new Fork
                    {
                        Brand = "Classic Utensils Inc.",
                        Model = "Vintage Fork",
                        PurchaseDate = DateTime.Parse("2023-10-03"),
                        Price = 24.99M,
                        HandleMaterial = "Wood",
                        TineCount = 4,
                        Rating = RateScale.Three
                    },
                      new Fork
                      {
                          Brand = "Eco-Friendly Forks",
                          Model = "Green Fork",
                          PurchaseDate = DateTime.Parse("2023-11-15"),
                          Price = 12.99M,
                          HandleMaterial = "Bamboo",
                          TineCount = 3,
                          Rating = RateScale.Three
                      },
                    new Fork
                    {
                        Brand = "Designer Dining",
                        Model = "Artisan Fork",
                        PurchaseDate = DateTime.Parse("2023-12-05"),
                        Price = 34.99M,
                        HandleMaterial = "Marble",
                        TineCount = 2,
                        Rating = RateScale.Four
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
