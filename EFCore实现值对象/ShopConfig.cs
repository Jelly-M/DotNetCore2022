using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore实现值对象
{
    internal class ShopConfig : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.OwnsOne(t => t.location);
        }
    }
}
