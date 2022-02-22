using Inf1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单理解洋葱架构
{
    public class MyEmailSender : IEmailSender
    {
        public Task SendAsync(string email, string title, string body)
        {
            Console.WriteLine($"通过smtp发邮件，{email},{title},{body}");
            return Task.CompletedTask;
        }
    }
}
