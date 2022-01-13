using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多对多关系
{
    public class Teacher
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students1 { get; set; } = new List<Student>();
    }

}
