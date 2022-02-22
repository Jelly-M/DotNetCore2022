using Inf1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单理解洋葱架构
{
    /// <summary>
    /// 模拟数据类
    /// </summary>
    public class MyDataProviderMock1 : IDataProvider
    {
        public IEnumerable<EmailInfo> GetEmailToBeSent()
        {
            yield return new EmailInfo("1@qq.com", "2", "3");
            yield return new EmailInfo("2@qq.com", "2", "3");
            yield return new EmailInfo("3@qq.com", "2", "3");
        }
    }
}
