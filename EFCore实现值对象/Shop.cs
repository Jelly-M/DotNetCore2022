using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore实现值对象
{
    internal class Shop
    {
        public int id { get; set; }
        public string name { get; set; }
        public Geo location { get; set; }
    }
}
