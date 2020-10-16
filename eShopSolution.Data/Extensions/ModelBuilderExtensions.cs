using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "en-AU", Name = "English", IsDefault = true },
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = false }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                }
            );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-AU", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Áo nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Women Shirt", LanguageId = "en-AU", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" },
                new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Áo nữ ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100,
                    Price = 200,
                    Stock = 0,
                    ViewCount = 0
                }
            );
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Pierre Cardin Men T-Shirt",
                    LanguageId = "en-AU",
                    SeoAlias = "pierre-cardin-men-t-shirt",
                    SeoDescription = "Pierre Cardin Men T-Shirt",
                    SeoTitle = "Pierre Cardin Men T-Shirt",
                    Details = "Pierre Cardin Men T-Shirt",
                    Description = "Pierre Cardin Men T-Shirt"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Áo sơ mi nam Pierre Cardin",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam-pierre-cardin",
                    SeoDescription = "Áo sơ mi nam Pierre Cardin",
                    SeoTitle = "Áo sơ mi nam Pierre Cardin",
                    Details = "Áo sơ mi nam Pierre Cardin",
                    Description = "Áo sơ mi nam Pierre Cardin"
                }
            );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
            );
        }
    }
}
