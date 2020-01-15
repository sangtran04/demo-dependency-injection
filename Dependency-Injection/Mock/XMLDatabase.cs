using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class XMLDatabase : IDatabase
    {
        public void Save(int orderId)
        {
            Console.WriteLine("Save to XML file");
        }
    }
}
