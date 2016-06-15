using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class AdjustableSplitter
    {
        int upPercentage;

        public void changePercentage(int newUpPercentage)
        {
            this.upPercentage = newUpPercentage;
        }

        public int getPercentage { get { return this.upPercentage; } }
    }
}
