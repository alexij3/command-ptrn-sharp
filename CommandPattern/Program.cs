using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Policy policy = new Policy();

            PolicyManager policyManager = new PolicyManager();

            ExportPolicy exportPolicy = new ExportPolicy(policy);
            ImportPolicy importPolicy = new ImportPolicy(policy);

            policyManager.transferPolicy(exportPolicy.Transfer);
            policyManager.transferPolicy(importPolicy.Transfer);

            policyManager.transferPolicy(policy.ExportPolicy);
            policyManager.transferPolicy(policy.ImportPolicy);

            Console.ReadLine();

        }
    }
}
