using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多对多关系
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers2 { get; set; } = new List<Teacher>();
        
    }
}
