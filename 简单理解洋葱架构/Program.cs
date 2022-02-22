// See https://aka.ms/new-console-template for more information
//string[] strAll = File.ReadAllLines("E:/temp/1.txt");//变化点，可以从不同的地方读取数据，数据库，文本，可以抽象出来
//foreach (string str in strAll)
//{
//    var tempStr = str.Split('|');
//    var email = tempStr[0];
//    var name = tempStr[1];
//    var body = tempStr[2];
//    Console.WriteLine($"邮箱={email},title={name},body={body}");//变化点，可以抽象出来，使用不同的方式进行发邮件
//}

using Inf1;
using Microsoft.Extensions.DependencyInjection;
using 简单理解洋葱架构;

ServiceCollection services=new ServiceCollection();
services.AddScoped<MyBizCode1>();
services.AddScoped<IEmailSender, MyEmailSender>();
services.AddScoped<IDataProvider, MyDataProvider>();
//services.AddScoped<IDataProvider, MyDataProviderMock1>(); //先进行模拟数据的测试，后再对文件进行测试

var sp = services.BuildServiceProvider();
var code1 = sp.GetRequiredService<MyBizCode1>();
await code1.DoItAsync();
Console.ReadLine();
