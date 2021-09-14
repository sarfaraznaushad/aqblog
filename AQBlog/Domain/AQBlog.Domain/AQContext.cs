using AQBlog.Domain.Infrastructure;
using AQBlog.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace AQBlog.Domain
{
    public class AQContext : DbContext
    {
        public AQContext(DbContextOptions<AQContext> options) : base(options)
        {

        }

        public DbSet<UserDetail> UserDetail { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<MasterDetail> MasterDetail { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<BlogDetail> BlogDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var passwordSalt = Encryption.RandomString();
            var password = Encryption.Encrypt("VYB90$%u", passwordSalt);
            modelBuilder.Entity<UserDetail>().HasData(new UserDetail()
            {
                IsDeleted = false,
                SaltPassword = passwordSalt,
                Password = password,
                UserName = "xyz@username.com"
            });

            modelBuilder.Entity<Category>().HasData(
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "ASP.NET" , UrlSlug= "ASP-NET", Description="ASP.NET Frame work" },
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "C#", UrlSlug = "C-Sharp", Description = "C# course" },
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "Sql", UrlSlug = "Sql", Description = "Sql Course" },
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "Java Script", UrlSlug = "Java-Script", Description = "Java script basic info" },
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "Angular", UrlSlug = "Angular", Description = "Angular Details" },
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "MongoDb", UrlSlug = "MongoDb", Description = "Mongodb Details" },
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "ASP.NET MVC", UrlSlug = "ASP-NET-MVC", Description = "ASP.Net Mvc Basic Detail" },
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "ASP.NET Core", UrlSlug = "ASP-NET-CORE", Description = "ASP.NET Core description" },
                new Category() { CreatedBy = null, CreatedOn = DateTime.UtcNow, Icon = "", IsDeleted = false, ModifiedBy = null, ModifiedOn = DateTime.UtcNow, ParentId = null, Title = "ASP.NET Blazor", UrlSlug = "ASP-NET-BLAZOR", Description = "ASP.NET Blazor Details" }
            );

            modelBuilder.Entity<MasterDetail>().HasData(
                new MasterDetail() { MasterCode = "TAGS", CreatedBy =  null, CreatedOn = DateTime.UtcNow, IsDeleted = false, MasterContent = "ASP.NET", ModifiedBy= null, ModifiedOn = DateTime.UtcNow },
                new MasterDetail() { MasterCode = "TAGS", CreatedBy = null, CreatedOn = DateTime.UtcNow, IsDeleted = false, MasterContent = "SQL", ModifiedBy = null, ModifiedOn = DateTime.UtcNow },
                new MasterDetail() { MasterCode = "TAGS", CreatedBy = null, CreatedOn = DateTime.UtcNow, IsDeleted = false, MasterContent = "ASP.NET CORE", ModifiedBy = null, ModifiedOn = DateTime.UtcNow },
                new MasterDetail() { MasterCode = "TAGS", CreatedBy = null, CreatedOn = DateTime.UtcNow, IsDeleted = false, MasterContent = "SQL", ModifiedBy = null, ModifiedOn = DateTime.UtcNow },
                new MasterDetail() { MasterCode = "TAGS", CreatedBy = null, CreatedOn = DateTime.UtcNow, IsDeleted = false, MasterContent = "JavaScript", ModifiedBy = null, ModifiedOn = DateTime.UtcNow },
                new MasterDetail() { MasterCode = "TAGS", CreatedBy = null, CreatedOn = DateTime.UtcNow, IsDeleted = false, MasterContent = "Angular", ModifiedBy = null, ModifiedOn = DateTime.UtcNow },
                new MasterDetail() { MasterCode = "TAGS", CreatedBy = null, CreatedOn = DateTime.UtcNow, IsDeleted = false, MasterContent = "MongoDb", ModifiedBy = null, ModifiedOn = DateTime.UtcNow },
                new MasterDetail() { MasterCode = "TAGS", CreatedBy = null, CreatedOn = DateTime.UtcNow, IsDeleted = false, MasterContent = "ASP.NET Blazor", ModifiedBy = null, ModifiedOn = DateTime.UtcNow }
                );
        }
    }
}
