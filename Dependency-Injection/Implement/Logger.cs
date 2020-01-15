using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Logger : ILogger
    {
        public void LogInfo(string info)
        {
            Console.WriteLine("Write real log");
        }
    }
}
