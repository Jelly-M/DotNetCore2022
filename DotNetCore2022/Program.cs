using System;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore2022
{
    class Program
    {
        //测试数据插入
        //测试递归缩进打印

        static async Task Main(string[] args)
        {
            //这样子指向类似一个双向图父节点指向子节点，子节点也指向父节点
            /* OrgUnit orgUnit = new OrgUnit() { Name = "中国省份和城市对应关系" };
             OrgUnit orgHn = new OrgUnit() { Name = "河南" };
             orgHn.Parent = orgUnit;
             orgUnit.Children.Add(orgHn);
             OrgUnit orgHb = new OrgUnit() { Name = "河北" };
             orgHb.Parent = orgUnit;
             orgUnit.Children.Add(orgHb);
             OrgUnit orgSd = new OrgUnit() {Name="山东" };
             orgSd.Parent = orgUnit;
             orgUnit.Children.Add(orgSd);

             OrgUnit orgSx = new OrgUnit() { Name = "山西" };
             orgSx.Parent = orgUnit;
             orgUnit.Children.Add(orgSx);

             OrgUnit orgZz = new OrgUnit() { Name = "郑州" };
             orgZz.Parent = orgHn;
             orgHn.Children.Add(orgZz);
             OrgUnit orgLy = new OrgUnit() { Name = "洛阳" };
             orgLy.Parent = orgHn;
             orgHn.Children.Add(orgLy);
             OrgUnit orgSjz = new OrgUnit() { Name = "石家庄" };
             orgSjz.Parent = orgHb;
             orgHb.Children.Add(orgSjz);
             OrgUnit orgHd = new OrgUnit() { Name = "邯郸" };
             orgHd.Parent = orgHb;
             orgHb.Children.Add(orgHd);
             OrgUnit orgJn = new OrgUnit() { Name = "济南" };
             orgJn.Parent = orgSd;
             orgSd.Children.Add(orgJn);
             OrgUnit orgQd = new OrgUnit() { Name = "青岛" };
             orgQd.Parent = orgSd;
             orgSd.Children.Add(orgQd);
             OrgUnit orgTy = new OrgUnit() { Name = "太原" };
             orgTy.Parent = orgTy;
             orgSx.Children.Add(orgTy);
             using (MyDbContext ctx=new MyDbContext())
             {
                 ctx.orgUnits.Add(orgUnit);

                await ctx.SaveChangesAsync();
             }*/
            // OrgUnit orgUnit = new OrgUnit() { Name = "中国省份和城市对应关系" };

            // OrgUnit orgHn = new OrgUnit() { Name = "河南" };
            // orgHn.Parent = orgUnit;
            // //orgUnit.Children.Add(orgHn);
            // OrgUnit orgHb = new OrgUnit() { Name = "河北" };
            // orgHb.Parent = orgUnit;
            // //orgUnit.Children.Add(orgHb);
            // OrgUnit orgSd = new OrgUnit() { Name = "山东" };
            // orgSd.Parent = orgUnit;
            // //orgUnit.Children.Add(orgSd);

            // OrgUnit orgSx = new OrgUnit() { Name = "山西" };
            // orgSx.Parent = orgUnit;
            //// orgUnit.Children.Add(orgSx);

            // OrgUnit orgZz = new OrgUnit() { Name = "郑州" };
            // orgZz.Parent = orgHn;
            // //orgHn.Children.Add(orgZz);
            // OrgUnit orgLy = new OrgUnit() { Name = "洛阳" };
            // orgLy.Parent = orgHn;
            // //orgHn.Children.Add(orgLy);
            // OrgUnit orgSjz = new OrgUnit() { Name = "石家庄" };
            // orgSjz.Parent = orgHb;
            // //orgHb.Children.Add(orgSjz);
            // OrgUnit orgHd = new OrgUnit() { Name = "邯郸" };
            // orgHd.Parent = orgHb;
            // //orgHb.Children.Add(orgHd);
            // OrgUnit orgJn = new OrgUnit() { Name = "济南" };
            // orgJn.Parent = orgSd;
            // //orgSd.Children.Add(orgJn);
            // OrgUnit orgQd = new OrgUnit() { Name = "青岛" };
            // orgQd.Parent = orgSd;
            // //orgSd.Children.Add(orgQd);
            // OrgUnit orgTy = new OrgUnit() { Name = "太原" };
            // orgTy.Parent = orgSx;
            // //orgSx.Children.Add(orgTy);
            // using (MyDbContext ctx = new MyDbContext())
            // {
            //     ctx.orgUnits.Add(orgUnit);
            //     ctx.orgUnits.Add(orgHn);
            //     ctx.orgUnits.Add(orgHb);
            //     ctx.orgUnits.Add(orgSd);
            //     ctx.orgUnits.Add(orgSx);
            //     ctx.orgUnits.Add(orgZz);
            //     ctx.orgUnits.Add(orgLy);
            //     ctx.orgUnits.Add(orgSjz);
            //     ctx.orgUnits.Add(orgHd);
            //     ctx.orgUnits.Add(orgJn);
            //     ctx.orgUnits.Add(orgQd);
            //     ctx.orgUnits.Add(orgTy);
            //     await ctx.SaveChangesAsync();
            // }
            using (MyDbContext ctx = new MyDbContext())
            {
                var parent = ctx.orgUnits.Single(t => t.Parent == null);//找到父节点
                Console.WriteLine(parent.Name);
                PrintChildren(1, ctx, parent);
            }
            
            Console.WriteLine("执行结束");
            Console.ReadKey();
        }
        /// <summary>
        /// 缩进打印parent得所有子节点 
        /// </summary>
        /// <param name="identLevel"></param>
        /// <param name="ctx"></param>
        /// <param name="orgUnit"></param>
        static void PrintChildren(int identLevel, MyDbContext ctx, OrgUnit orgUnit)
        {
            var children=ctx.orgUnits.Where(x => x.Parent == orgUnit);
            foreach (var child in children)
            {
                Console.WriteLine(new String('\t', identLevel)+child.Name);
                PrintChildren(identLevel+1, ctx, child);//打印以我为父节点得所有子节点
            }
        }
    }
    
}
