using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCore2022
{
    public class OrgUnitTypeConfigrution : IEntityTypeConfiguration<OrgUnit>
    {
        public void Configure(EntityTypeBuilder<OrgUnit> builder)
        {
            builder.ToTable("T_OrgUnits");
            builder.Property(o => o.Name).IsUnicode().IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.Parent).WithMany(x => x.Children);//根节点没有parent,因此这个关系中不可以修饰为不可为空，可为空
        }
    }
}
