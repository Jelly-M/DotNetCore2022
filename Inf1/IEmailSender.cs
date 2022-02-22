using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf1
{
    public interface IEmailSender
    {
        public Task SendAsync(string email,string title,string body);
    }
}
