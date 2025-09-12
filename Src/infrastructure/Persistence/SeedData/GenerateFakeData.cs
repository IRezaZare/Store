using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence.SeedData;

public class GenerateFakeData
{
    public static async Task SeedDataAsync(ApplicationDbContext context, ILoggerFactory loggerFactory)
    {
        try
        {
            if (!await context.ProductBrands.AnyAsync())
            {
                var Brands = ProductBrands();
                await context.AddRangeAsync(Brands);
                await context.SaveChangesAsync();
            }
            if (!await context.ProductTypes.AnyAsync())
            {
                var Types = ProductTypes();
                await context.AddRangeAsync(Types);
                await context.SaveChangesAsync();
            }
            if (!await context.Products.AnyAsync())
            {
                var products = Products();
                await context.AddRangeAsync(products);
                await context.SaveChangesAsync();
            }
        }
        catch (Exception e)
        {
            var logger = loggerFactory.CreateLogger<GenerateFakeData>();
            logger.LogError(e, "error in Seed Data");
        }
    }
    private static IEnumerable<Product> Products()
    {
        var products = new List<Product>()
        {
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 2",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 3",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            }
        };
        return products;
    }
    private static IEnumerable<ProductBrand> ProductBrands()
    {
        var brands = new List<ProductBrand>()
        {
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate ",
                Title = "brand1",
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate ",
                Title = "brand2",
            }
        };
        return brands;
    }
    private static IEnumerable<ProductType> ProductTypes()
    {
        var types = new List<ProductType>()
        {
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate ",
                Title = "brand1",
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate ",
                Title = "brand2",
            }
        };
        return types;
    }

}

