using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class FakeLogger : ILogger
    {
        public void LogInfo(string info)
        {
            Console.WriteLine("Fake log");
        }
    }
}
