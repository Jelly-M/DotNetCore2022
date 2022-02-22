using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf1
{
    public interface IDataProvider
    {
        /// <summary>
        /// 返回待发送的一些信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmailInfo> GetEmailToBeSent();
    }
}
