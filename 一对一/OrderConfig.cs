using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一对一
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("T_Order");
            //在order 实体中进行配置
            builder.HasOne<Delivery>(o => o.Delivery).WithOne(t => t.Order)
                .HasForeignKey<Delivery>(t => t.OrderId);  //配置外键关系
        }
    }
}
