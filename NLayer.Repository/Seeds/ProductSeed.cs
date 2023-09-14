using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kitap",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Defter",
                Price = 200,
                Stock = 20,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Kitap2",
                Price = 300,
                Stock = 20,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 4,
                CategoryId = 1,
                Name = "Kitap3",
                Price = 400,
                Stock = 20,
                CreatedDate = DateTime.Now,
            });
        }
    }
}
