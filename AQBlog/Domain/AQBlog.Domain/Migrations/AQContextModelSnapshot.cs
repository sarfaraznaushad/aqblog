﻿// <auto-generated />
using System;
using AQBlog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AQBlog.Domain.Migrations
{
    [DbContext(typeof(AQContext))]
    partial class AQContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AQBlog.Model.BlogDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Tags")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("UrlSlug")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("BlogDetail");
                });

            modelBuilder.Entity("AQBlog.Model.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Icon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParentId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UrlSlug")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = "4dfbb6ba-bdd9-45ab-a37c-3785b0e57105",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 405, DateTimeKind.Utc).AddTicks(8752),
                            Description = "ASP.NET Frame work",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 405, DateTimeKind.Utc).AddTicks(9990),
                            Title = "ASP.NET",
                            UrlSlug = "ASP-NET"
                        },
                        new
                        {
                            Id = "8da3b728-0242-4286-a5dc-7eba46a66cb2",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1870),
                            Description = "C# course",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1873),
                            Title = "C#",
                            UrlSlug = "C-Sharp"
                        },
                        new
                        {
                            Id = "eb5c3130-911e-4903-98fd-fcebe0d2a779",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1878),
                            Description = "Sql Course",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1879),
                            Title = "Sql",
                            UrlSlug = "Sql"
                        },
                        new
                        {
                            Id = "6c60d4a2-008d-4015-a23b-80e21c5530fc",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1893),
                            Description = "Java script basic info",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1894),
                            Title = "Java Script",
                            UrlSlug = "Java-Script"
                        },
                        new
                        {
                            Id = "e00c702d-beec-4554-88ab-fc0bb6d679d6",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1897),
                            Description = "Angular Details",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1898),
                            Title = "Angular",
                            UrlSlug = "Angular"
                        },
                        new
                        {
                            Id = "3c9e274e-8c67-400d-acfc-60eb47c89b85",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1901),
                            Description = "Mongodb Details",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1902),
                            Title = "MongoDb",
                            UrlSlug = "MongoDb"
                        },
                        new
                        {
                            Id = "d48ddd93-5ebf-4fe0-9042-74541f16f576",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1905),
                            Description = "ASP.Net Mvc Basic Detail",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1906),
                            Title = "ASP.NET MVC",
                            UrlSlug = "ASP-NET-MVC"
                        },
                        new
                        {
                            Id = "23804972-5065-4b85-9caa-51be82628385",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1909),
                            Description = "ASP.NET Core description",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1910),
                            Title = "ASP.NET Core",
                            UrlSlug = "ASP-NET-CORE"
                        },
                        new
                        {
                            Id = "28c01d56-b3c9-45ca-9185-4c0ba8ea90fd",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1913),
                            Description = "ASP.NET Blazor Details",
                            Icon = "",
                            IsActive = false,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1914),
                            Title = "ASP.NET Blazor",
                            UrlSlug = "ASP-NET-BLAZOR"
                        });
                });

            modelBuilder.Entity("AQBlog.Model.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BlogId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("AQBlog.Model.MasterDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MasterCode")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MasterContent")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MasterDetail");

                    b.HasData(
                        new
                        {
                            Id = "7ee4294e-168b-4abc-9a2c-04db80ebe511",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(2942),
                            IsDeleted = false,
                            MasterCode = "TAGS",
                            MasterContent = "ASP.NET",
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3303)
                        },
                        new
                        {
                            Id = "e0428e9c-0a7e-49be-a08a-5e61442937db",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3313),
                            IsDeleted = false,
                            MasterCode = "TAGS",
                            MasterContent = "SQL",
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3314)
                        },
                        new
                        {
                            Id = "f2279094-8efa-42d2-aad9-f4456451e018",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3322),
                            IsDeleted = false,
                            MasterCode = "TAGS",
                            MasterContent = "ASP.NET CORE",
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3323)
                        },
                        new
                        {
                            Id = "039da0a7-9a73-401e-99e8-3c1e22f9b3ef",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3326),
                            IsDeleted = false,
                            MasterCode = "TAGS",
                            MasterContent = "SQL",
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3327)
                        },
                        new
                        {
                            Id = "befd70ba-562b-4899-b7c7-246509a8b8fd",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3330),
                            IsDeleted = false,
                            MasterCode = "TAGS",
                            MasterContent = "JavaScript",
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3331)
                        },
                        new
                        {
                            Id = "8c68a68a-cdb3-4d06-81eb-66fb5a13cd3b",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3334),
                            IsDeleted = false,
                            MasterCode = "TAGS",
                            MasterContent = "Angular",
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3335)
                        },
                        new
                        {
                            Id = "1c874e59-490f-440d-966e-03da42293c30",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3337),
                            IsDeleted = false,
                            MasterCode = "TAGS",
                            MasterContent = "MongoDb",
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3338)
                        },
                        new
                        {
                            Id = "1ce45958-9a39-4dd7-978b-d773615b46b7",
                            CreatedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3341),
                            IsDeleted = false,
                            MasterCode = "TAGS",
                            MasterContent = "ASP.NET Blazor",
                            ModifiedOn = new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3342)
                        });
                });

            modelBuilder.Entity("AQBlog.Model.UserDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SaltPassword")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("UserDetail");

                    b.HasData(
                        new
                        {
                            Id = "175b5eba-6831-40e6-9da1-553aeb9d1679",
                            IsDeleted = false,
                            Password = "0XA7lWZfyJvKQcIWY2K30A==",
                            SaltPassword = "e12f840e335f428aad41986ba96b0470",
                            UserName = "xyz@username.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
