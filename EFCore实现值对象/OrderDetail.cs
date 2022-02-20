using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore实现值对象
{
    internal class OrderDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Order Order { get; set; }
        public Goods Goods { get; set; }
        public int Count { get; set; }
    }
}
