// See https://aka.ms/new-console-template for more information
using EFCore实现值对象;

Console.WriteLine("Hello, World!");
Shop shop=new Shop();
shop.name = "zhangsan";
Geo g=new Geo(4,5);
shop.location = g;
using (MyDbcontext my=new MyDbcontext())
{
    my.Shops.Add(shop);
    my.SaveChanges();
}