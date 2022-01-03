using Microsoft.EntityFrameworkCore;
using System;

namespace 多对多关系
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Name = "张三" };
            Student s2 = new Student { Name = "李四" };
            Student s3 = new Student { Name = "王五" };

            Teacher t1 = new Teacher { Name = "Tom" };
            Teacher t2 = new Teacher { Name = "lily" };
            Teacher t3 = new Teacher { Name = "Jerry" };
            s1.Teachers2.Add(t1);
            s1.Teachers2.Add(t2);

            s2.Teachers2.Add(t2);
            s2.Teachers2.Add(t3);

            s3.Teachers2.Add(t3);
            s3.Teachers2.Add(t1);

            using (MyDbContext ctx=new MyDbContext())
            {
                //加入到对应的dbcontext中
                //ctx.Stundets.Add(s1);
                //ctx.Stundets.Add(s2);
                //ctx.Stundets.Add(s3);


                //ctx.Teachers.Add(t1);
                //ctx.Teachers.Add(t2);
                //ctx.Teachers.Add(t3);

                //ctx.SaveChanges();
                var teacher = ctx.Teachers.Include(t => t.Students1);
                foreach (var item in teacher)
                {
                    Console.WriteLine(item.Name);
                    foreach (var stu in item.Students1)
                    {
                        Console.WriteLine('\t'+stu.Name);
                    }
                }

            }

        }
    }
}
