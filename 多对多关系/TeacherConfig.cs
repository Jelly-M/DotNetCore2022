using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多对多关系
{
    class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("T_Teacher");
            //测试发现表里的字段名字是根据这个Student1,和Teacher2来的，不是DbContext的值
            builder.HasMany<Student>(x => x.Students1).WithMany(x => x.Teachers2)
                .UsingEntity(j => j.ToTable("T_Teacher_Student"));//指定外键表名
        }
    }
}
