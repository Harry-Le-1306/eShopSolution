﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eShopSolution.Data.EF;

namespace eShopSolution.Data.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    partial class EShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eShopSolution.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");

                    b.HasData(
                        new
                        {
                            Key = "HomeTitle",
                            Value = "This is homepage of eShopSolution"
                        },
                        new
                        {
                            Key = "HomeKeyword",
                            Value = "This is keyword of eShopSolution"
                        },
                        new
                        {
                            Key = "HomeDescription",
                            Value = "This is description of eShopSolution"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsShowOnHome")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsShowOnHome = true,
                            SortOrder = 1,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            IsShowOnHome = true,
                            SortOrder = 2,
                            Status = 1
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.CategoryTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageId")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SeoAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SeoDescription")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("SeoTitle")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CategoryTranslations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            LanguageId = "en-AU",
                            Name = "Men Shirt",
                            SeoAlias = "men-shirt",
                            SeoDescription = "The shirt products for men",
                            SeoTitle = "The shirt products for men"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            LanguageId = "vi-VN",
                            Name = "Áo nam",
                            SeoAlias = "ao-nam",
                            SeoDescription = "Sản phẩm áo thời trang nam",
                            SeoTitle = "Sản phẩm áo thời trang nam"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            LanguageId = "en-AU",
                            Name = "Women Shirt",
                            SeoAlias = "women-shirt",
                            SeoDescription = "The shirt products for women",
                            SeoTitle = "The shirt products for women"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            LanguageId = "vi-VN",
                            Name = "Áo nữ ",
                            SeoAlias = "ao-nu",
                            SeoDescription = "Sản phẩm áo thời trang nữ",
                            SeoTitle = "Sản phẩm áo thời trang nữ"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Language", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = "en-AU",
                            IsDefault = true,
                            Name = "English"
                        },
                        new
                        {
                            Id = "vi-VN",
                            IsDefault = false,
                            Name = "Tiếng Việt"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 10, 16, 20, 45, 19, 55, DateTimeKind.Local).AddTicks(9326));

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ShipEmail")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ShipPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2020, 10, 16, 20, 45, 19, 73, DateTimeKind.Local).AddTicks(4516),
                            OriginalPrice = 100m,
                            Price = 200m,
                            Stock = 0,
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductInCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("LanguageId")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("SeoAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SeoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTranlations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pierre Cardin Men T-Shirt",
                            Details = "Pierre Cardin Men T-Shirt",
                            LanguageId = "en-AU",
                            Name = "Pierre Cardin Men T-Shirt",
                            ProductId = 1,
                            SeoAlias = "pierre-cardin-men-t-shirt",
                            SeoDescription = "Pierre Cardin Men T-Shirt",
                            SeoTitle = "Pierre Cardin Men T-Shirt"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Áo sơ mi nam Pierre Cardin",
                            Details = "Áo sơ mi nam Pierre Cardin",
                            LanguageId = "vi-VN",
                            Name = "Áo sơ mi nam Pierre Cardin",
                            ProductId = 1,
                            SeoAlias = "ao-so-mi-nam-pierre-cardin",
                            SeoDescription = "Áo sơ mi nam Pierre Cardin",
                            SeoTitle = "Áo sơ mi nam Pierre Cardin"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ApplyForAll")
                        .HasColumnType("bit");

                    b.Property<decimal?>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DiscountPercent")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCategoryIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ExternalTransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Cart", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.CategoryTranslation", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Category", "Category")
                        .WithMany("CategoryTranslations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Language", "Language")
                        .WithMany("CategoryTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductInCategory", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Category", "Category")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductTranslation", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Language", "Language")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
