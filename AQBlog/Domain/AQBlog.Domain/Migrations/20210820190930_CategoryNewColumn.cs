using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AQBlog.Domain.Migrations
{
    public partial class CategoryNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "0e2ba2e5-fb3e-4706-8973-89317fdea090");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "178781c6-035a-43a6-b04f-73c85313e191");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2238bc13-e988-485f-9bf6-206fb5020f21");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "363a9d86-d8f8-43c5-bd0f-f46ee53e44d3");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "67c6687e-47fd-4711-a184-4abafed43d5d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6ef0af10-810a-4d9c-aad7-b898b211cbab");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "aeaa024d-8d86-4459-a1b7-25bd4f69465d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "d2b2452b-734c-47f9-9828-a8894f004770");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "dacad5a6-1f4a-42dc-83f5-32ad05dd2fbf");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "0e86582e-9bb2-4d2e-9ac1-8599d7360df9");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "2477d88a-7818-483f-8910-43114b28d4b7");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "479c057a-967a-4db3-b7c7-acd5f9bed53c");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "56b7aa8f-538c-4e9f-ba17-363781fc5e37");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "8d5984d7-e206-4628-acd7-25f20f595bce");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "d6fae695-6ce1-4f30-a8d6-d142558b47ed");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "d732b556-0cab-4753-8b9a-87a1e74208b0");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "e624c553-ff33-4ab3-922d-e01f02e86c23");

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "Id",
                keyValue: "032e39d9-fe32-46c5-aa7f-2bb70413240d");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Icon", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "ParentId", "Title", "UrlSlug" },
                values: new object[,]
                {
                    { "4dfbb6ba-bdd9-45ab-a37c-3785b0e57105", null, new DateTime(2021, 8, 20, 19, 9, 30, 405, DateTimeKind.Utc).AddTicks(8752), "ASP.NET Frame work", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 405, DateTimeKind.Utc).AddTicks(9990), null, "ASP.NET", "ASP-NET" },
                    { "23804972-5065-4b85-9caa-51be82628385", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1909), "ASP.NET Core description", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1910), null, "ASP.NET Core", "ASP-NET-CORE" },
                    { "d48ddd93-5ebf-4fe0-9042-74541f16f576", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1905), "ASP.Net Mvc Basic Detail", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1906), null, "ASP.NET MVC", "ASP-NET-MVC" },
                    { "3c9e274e-8c67-400d-acfc-60eb47c89b85", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1901), "Mongodb Details", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1902), null, "MongoDb", "MongoDb" },
                    { "28c01d56-b3c9-45ca-9185-4c0ba8ea90fd", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1913), "ASP.NET Blazor Details", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1914), null, "ASP.NET Blazor", "ASP-NET-BLAZOR" },
                    { "6c60d4a2-008d-4015-a23b-80e21c5530fc", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1893), "Java script basic info", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1894), null, "Java Script", "Java-Script" },
                    { "eb5c3130-911e-4903-98fd-fcebe0d2a779", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1878), "Sql Course", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1879), null, "Sql", "Sql" },
                    { "8da3b728-0242-4286-a5dc-7eba46a66cb2", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1870), "C# course", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1873), null, "C#", "C-Sharp" },
                    { "e00c702d-beec-4554-88ab-fc0bb6d679d6", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1897), "Angular Details", "", false, false, null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(1898), null, "Angular", "Angular" }
                });

            migrationBuilder.InsertData(
                table: "MasterDetail",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsDeleted", "MasterCode", "MasterContent", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { "1ce45958-9a39-4dd7-978b-d773615b46b7", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3341), false, "TAGS", "ASP.NET Blazor", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3342) },
                    { "7ee4294e-168b-4abc-9a2c-04db80ebe511", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(2942), false, "TAGS", "ASP.NET", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3303) },
                    { "e0428e9c-0a7e-49be-a08a-5e61442937db", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3313), false, "TAGS", "SQL", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3314) },
                    { "f2279094-8efa-42d2-aad9-f4456451e018", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3322), false, "TAGS", "ASP.NET CORE", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3323) },
                    { "039da0a7-9a73-401e-99e8-3c1e22f9b3ef", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3326), false, "TAGS", "SQL", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3327) },
                    { "befd70ba-562b-4899-b7c7-246509a8b8fd", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3330), false, "TAGS", "JavaScript", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3331) },
                    { "8c68a68a-cdb3-4d06-81eb-66fb5a13cd3b", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3334), false, "TAGS", "Angular", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3335) },
                    { "1c874e59-490f-440d-966e-03da42293c30", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3337), false, "TAGS", "MongoDb", null, new DateTime(2021, 8, 20, 19, 9, 30, 406, DateTimeKind.Utc).AddTicks(3338) }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "Id", "IsDeleted", "Password", "SaltPassword", "UserName" },
                values: new object[] { "175b5eba-6831-40e6-9da1-553aeb9d1679", false, "0XA7lWZfyJvKQcIWY2K30A==", "e12f840e335f428aad41986ba96b0470", "xyz@username.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "23804972-5065-4b85-9caa-51be82628385");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "28c01d56-b3c9-45ca-9185-4c0ba8ea90fd");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3c9e274e-8c67-400d-acfc-60eb47c89b85");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4dfbb6ba-bdd9-45ab-a37c-3785b0e57105");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6c60d4a2-008d-4015-a23b-80e21c5530fc");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "8da3b728-0242-4286-a5dc-7eba46a66cb2");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "d48ddd93-5ebf-4fe0-9042-74541f16f576");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "e00c702d-beec-4554-88ab-fc0bb6d679d6");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "eb5c3130-911e-4903-98fd-fcebe0d2a779");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "039da0a7-9a73-401e-99e8-3c1e22f9b3ef");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "1c874e59-490f-440d-966e-03da42293c30");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "1ce45958-9a39-4dd7-978b-d773615b46b7");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "7ee4294e-168b-4abc-9a2c-04db80ebe511");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "8c68a68a-cdb3-4d06-81eb-66fb5a13cd3b");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "befd70ba-562b-4899-b7c7-246509a8b8fd");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "e0428e9c-0a7e-49be-a08a-5e61442937db");

            migrationBuilder.DeleteData(
                table: "MasterDetail",
                keyColumn: "Id",
                keyValue: "f2279094-8efa-42d2-aad9-f4456451e018");

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "Id",
                keyValue: "175b5eba-6831-40e6-9da1-553aeb9d1679");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Category");

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
                values: new object[] { "032e39d9-fe32-46c5-aa7f-2bb70413240d", false, "Bqwq12Laz1VTk4HK95C99Q==", "e39b5a70d4f24f789ada1a5227a18720", "sarfaraz.naushad@gmail.com" });
        }
    }
}
