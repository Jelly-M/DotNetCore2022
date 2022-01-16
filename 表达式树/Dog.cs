using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 表达式树
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string age { get; init; }
        public Dog(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
