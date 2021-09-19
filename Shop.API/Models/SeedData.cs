using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Shop.API.Context;
using System;
using System.Linq;

namespace Shop.API.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApiContext
                (serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }

                context.Pages.AddRange(
                    new Page
                    {
                        Name = "Home",
                        Slug = "home",
                        Content = "Home Page",
                    }, new Page
                    {
                        Name = "AboutUs",
                        Slug = "about-us",
                        Content = "aboutUs Page",
                    }, new Page
                    {
                        Name = "Services",
                        Slug = "services",
                        Content = "Services Page",
                    }, new Page
                    {
                        Name = "Content",
                        Slug = "content",
                        Content = "Content Page",
                    }
                );

                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Fruits",
                        Slug = "fruits",
                    }, new Category
                    {
                        Name = "T-Shirt",
                        Slug = "t-shirt",
                    }
                );
                context.Products.AddRange(
                    new Product
                    {
                        Name = "White Shirts",
                        CategoryId = 1,
                        Description = "a white tshirt",
                        Image = "white_tshirt.jpg",
                        Price = 1.99M,
                    }, new Product
                    {
                        Name = "Apples",
                        CategoryId = 2,
                        Description = "a red apples",
                        Image = "fruits.jpg",
                        Price = 2.99M,
                    }
                );

                context.SaveChanges();

            }
        }
    }
}
