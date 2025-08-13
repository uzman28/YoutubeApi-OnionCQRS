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
    public class DetailConfiguation:IEntityTypeConfiguration<Detail>
    {
       public void Configure(EntityTypeBuilder<Detail> builder)
        {
          Faker faker= new Faker();

            Detail detail1 = new()
            {
                ID = 1,
                Description = faker.Lorem.Paragraph(),
                Title = faker.Lorem.Sentence(),
                CategoryId = 1,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            Detail detail2 = new()
            {
                ID = 2,
                Description = faker.Lorem.Paragraph(),
                Title = faker.Lorem.Sentence(),
                CategoryId = 1,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            Detail detail3 = new()
            {
                ID = 3,
                Description = faker.Lorem.Paragraph(),
                Title = faker.Lorem.Sentence(),
                CategoryId = 1,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };

        }
    
    
    }
    
    }

