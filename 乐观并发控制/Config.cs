using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乐观并发控制
{
    public class Config : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.ToTable("T_Houses");
            builder.Property(t => t.RowVer).IsRowVersion();
        }
    }
}
