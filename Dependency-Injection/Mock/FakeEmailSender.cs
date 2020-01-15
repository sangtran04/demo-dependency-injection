using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class FakeEmailSender : IEmailSender
    {
        public void SendEmail(int userId)
        {
            Console.WriteLine("Send fake email");
        }
    }
}
