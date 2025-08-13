using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker= new Faker("tr");
            Product product1 = new()
            {
                ID = 1,
                BrandId = 1,
                Price=1000,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
                Description = faker.Lorem.Paragraph(),
                Discount = faker.Random.Decimal(0, 0.5m),
                Title="faker.Commerce.ProductName",
            };
            Product product2 = new()
            {
                ID = 2,
                BrandId = 1,
                Price = 1000,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
                Description = faker.Lorem.Paragraph(),
                Discount = faker.Random.Decimal(0, 0.5m),
                Title = "faker.Commerce.ProductName",
            };
            Product product3 = new()
            {
                ID = 3,
                BrandId = 1,
                Price = 1000,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
                Description = faker.Lorem.Paragraph(),
                Discount = faker.Random.Decimal(0, 0.5m),
                Title = "faker.Commerce.ProductName",
            };
            builder.HasData(
                product1,
                product2,
                product3
            );
        }
    }
}
