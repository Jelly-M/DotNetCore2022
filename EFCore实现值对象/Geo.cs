using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore实现值对象
{
    internal class Geo
    {
        public double Jingdu { get; set; }
        public double Latitude { get; set; }
        public Geo()
        {

        }
        public Geo(double jingdu,double weidu)
        {
            this.Jingdu = jingdu;
            this.Latitude= weidu;
        }
    }
}
