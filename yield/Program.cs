// See https://aka.ms/new-console-template for more information
//IQueryable,IEnumerable都有可能延迟加载问题，那主要的区别就是IQueryable可以继续的进行linq的操作，
//都是在遍历集合的时候才去加载完成
//需要碰到总结函数才去执行

//内存缓存
Console.WriteLine("Hello, World!");
Console.WriteLine("111");
foreach (var item in Get())
{
    Console.WriteLine(item);
}
Console.ReadKey();
IEnumerable<int> Get()
{
    yield return 1;
    yield return 2;
    yield return 3;
    Console.WriteLine("22222");
    yield return 4;
    //List<int> list=new List<int> { 1, 2, 3 };
    //return list;
}