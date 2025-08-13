using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            Faker faker = new("tr");

            Brand brand1 = new() {
                ID = 1,
                Name = faker.Commerce.Department(),
                CreatedTime = DateTime.Now,
                IsDeleted = false,

            };

            Brand brand2 = new()
            {
                ID = 2,
                Name = faker.Commerce.Department(),
                CreatedTime = DateTime.Now,
                IsDeleted = false,

            };

            Brand brand3 = new()
            {
                ID = 3,
                Name = faker.Commerce.Department(),
                CreatedTime = DateTime.Now,
                IsDeleted = true,

            };



            builder.HasData();
        }
    }
}
