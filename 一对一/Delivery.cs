using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一对一
{
    /// <summary>
    /// 快递单 
    /// </summary>
    public class Delivery
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string DeliveryNo { get; set; }
        public Order Order { get; set; }
        public long OrderId { get; set; }
    }
}
