using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class ExportPolicy
    {
        Policy policy;

        public ExportPolicy(Policy policy)
        {
            this.policy = policy;
        }

        public void Transfer()
        {
            policy.ExportPolicy();
        }
    }
}
