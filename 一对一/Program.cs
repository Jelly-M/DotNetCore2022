using System;

namespace 一对一
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext ctx=new MyDbContext())
            {

                Order order = new Order();
                order.Name = "这个是书的名字";

                Delivery delivery = new Delivery();
                delivery.CompanyName = "xxxx快递";
                delivery.DeliveryNo = "zzade001";
                delivery.Order = order;

                //这里面只需要添加Delivery就可以了
                ctx.Orders.Add(order);
                ctx.Deliveries.Add(delivery);
                ctx.SaveChanges();
            }
        }
    }
}
