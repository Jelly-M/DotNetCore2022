using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore实现值对象
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public double TotalAmount { get; set; }
        public List<OrderDetail> Details { get; set; }
        //添加商品
        public void AddDetail(Goods goods,int count)
        {
            var any = Details.Single(x => x.Goods == goods);
            if (any != null)
            {
                Details.Add(new OrderDetail() { Goods = goods, Count = count });
            }
            else 
                any.Count += count;
        }
    }
}
