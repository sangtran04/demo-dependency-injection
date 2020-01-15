using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Database : IDatabase
    {
        public void Save(int orderId)
        {
            Console.WriteLine("Saved to real database");
        }
    }
}
