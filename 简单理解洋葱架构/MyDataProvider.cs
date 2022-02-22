using Inf1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单理解洋葱架构
{
    public class MyDataProvider : IDataProvider
    {
        public IEnumerable<EmailInfo> GetEmailToBeSent()
        {
            string[] strAll = File.ReadAllLines("E:/temp/1.txt");
            foreach (string str in strAll)
            {
                var tempStr = str.Split('|');
                var email = tempStr[0];
                var name = tempStr[1];
                var body = tempStr[2];
                yield return new EmailInfo(email, title: name, body: body); //遇到yield return 后会立即返回执行掉用处方法，
            }
        }
    }
}
