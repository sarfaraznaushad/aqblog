using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AQBlog.Domain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UrlSlug = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ParentId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UrlSlug = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BlogId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MasterCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    MasterContent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SaltPassword = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Icon", "IsDeleted", "ModifiedBy", "ModifiedOn", "ParentId", "Title", "UrlSlug" },
                values: new object[,]
                {
                    { "2238bc13-e988-485f-9bf6-206fb5020f21", null, new DateTime(2021, 8, 14, 16, 42, 38, 955, DateTimeKind.Utc).AddTicks(7640), "ASP.NET Frame work", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 955, DateTimeKind.Utc).AddTicks(8864), null, "ASP.NET", "ASP-NET" },
                    { "0e2ba2e5-fb3e-4706-8973-89317fdea090", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(737), "ASP.NET Core description", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(738), null, "ASP.NET Core", "ASP-NET-CORE" },
                    { "67c6687e-47fd-4711-a184-4abafed43d5d", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(733), "ASP.Net Mvc Basic Detail", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(734), null, "ASP.NET MVC", "ASP-NET-MVC" },
                    { "363a9d86-d8f8-43c5-bd0f-f46ee53e44d3", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(729), "Mongodb Details", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(730), null, "MongoDb", "MongoDb" },
                    { "6ef0af10-810a-4d9c-aad7-b898b211cbab", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(742), "ASP.NET Blazor Details", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(742), null, "ASP.NET Blazor", "ASP-NET-BLAZOR" },
                    { "dacad5a6-1f4a-42dc-83f5-32ad05dd2fbf", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(713), "Java script basic info", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(714), null, "Java Script", "Java-Script" },
                    { "aeaa024d-8d86-4459-a1b7-25bd4f69465d", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(708), "Sql Course", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(710), null, "Sql", "Sql" },
                    { "d2b2452b-734c-47f9-9828-a8894f004770", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(699), "C# course", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(703), null, "C#", "C-Sharp" },
                    { "178781c6-035a-43a6-b04f-73c85313e191", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(725), "Angular Details", "", false, null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(726), null, "Angular", "Angular" }
                });

            migrationBuilder.InsertData(
                table: "MasterDetail",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsDeleted", "MasterCode", "MasterContent", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { "479c057a-967a-4db3-b7c7-acd5f9bed53c", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2199), false, "TAGS", "ASP.NET Blazor", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2200) },
                    { "e624c553-ff33-4ab3-922d-e01f02e86c23", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(1797), false, "TAGS", "ASP.NET", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2158) },
                    { "2477d88a-7818-483f-8910-43114b28d4b7", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2169), false, "TAGS", "SQL", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2170) },
                    { "0e86582e-9bb2-4d2e-9ac1-8599d7360df9", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2174), false, "TAGS", "ASP.NET CORE", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2175) },
                    { "d6fae695-6ce1-4f30-a8d6-d142558b47ed", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2183), false, "TAGS", "SQL", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2184) },
                    { "8d5984d7-e206-4628-acd7-25f20f595bce", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2187), false, "TAGS", "JavaScript", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2188) },
                    { "56b7aa8f-538c-4e9f-ba17-363781fc5e37", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2191), false, "TAGS", "Angular", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2192) },
                    { "d732b556-0cab-4753-8b9a-87a1e74208b0", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2195), false, "TAGS", "MongoDb", null, new DateTime(2021, 8, 14, 16, 42, 38, 956, DateTimeKind.Utc).AddTicks(2196) }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "Id", "IsDeleted", "Password", "SaltPassword", "UserName" },
                values: new object[] { "032e39d9-fe32-46c5-aa7f-2bb70413240d", false, "Bqwq12Laz1VTk4HK95C99Q==", "e39b5a70d4f24f789ada1a5227a18720", "xyz@username.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogDetail");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "MasterDetail");

            migrationBuilder.DropTable(
                name: "UserDetail");
        }
    }
}
