using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Policy
    {
        public void ImportPolicy()
        {
            Console.WriteLine("Import policy.");
        }

        public void ExportPolicy()
        {
            Console.WriteLine("Export policy.");
        }
    }
}
