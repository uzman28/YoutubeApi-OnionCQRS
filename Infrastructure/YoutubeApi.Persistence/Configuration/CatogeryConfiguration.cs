using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configuration
{
    public class CatogeryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                ID = 1,
                Priorty= 1,
                ParentId = 0,
                Name = "Elektrik",
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            Category category2 = new()
            {
                ID = 2,
                Priorty = 2,
                ParentId = 0,
                Name = "Moda",
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };

            Category Parent1 = new()
            {
                ID = 3,
                Priorty = 1,
                ParentId = 1,
                Name = "Bilgisayar",
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            Category Parent2 = new()
            {
                ID = 4,
                Priorty = 2,
                ParentId = 1,
                Name = "Kadın",
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };

            builder.HasData(
                category1,
                category2,
                Parent1,
                Parent2
            );


        }
    }
}
