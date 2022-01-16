using System;

namespace 表达式树
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            Person p1 = new Person(1, "lz", 18);
            Person p2 = new Person(1, "lz", 18);
            Person p3 = new Person(1, "lz", 43);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1==p2); //true 使用record 只要对象的属性值相等，这个对象就像等
            Console.WriteLine(p3==p2);//falsle
            Console.WriteLine(object.ReferenceEquals(p1, p2)); //false 判断两个对象的引用是否相等的
        }
    }
}
