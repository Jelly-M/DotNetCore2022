using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf1
{
    /// <summary>
    /// 业务逻辑类
    /// </summary>
    public class MyBizCode1
    {
        public IEmailSender EmailSender;
        public IDataProvider DataProvider;

        public MyBizCode1(IEmailSender emailSender, IDataProvider dataProvider)
        {
            EmailSender = emailSender;
            DataProvider = dataProvider;
        }
        public async Task DoItAsync()
        {
            //得到要发送的邮件
            var items = DataProvider.GetEmailToBeSent();
            foreach (var item in items)
            {
               await EmailSender.SendAsync(item.email, item.title, item.body);
                await Task.Delay(1000);
            }
        }
    }
}
