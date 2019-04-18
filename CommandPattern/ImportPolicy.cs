using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class ImportPolicy
    {
        Policy policy;

        public ImportPolicy(Policy policy)
        {
            this.policy = policy;
        }

        public void Transfer()
        {
            policy.ImportPolicy();
        }
    }
}
