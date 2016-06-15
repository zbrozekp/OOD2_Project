using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class Pump
    {
        double currentFlow;
        Pipeline output;

        public void changeConnections(Pipeline newOutput)
        {
            this.output = newOutput;
        }

        public void changeFlow(double newCurrentFlow)
        {
            this.currentFlow = newCurrentFlow;
        }

        public double getCurrentFlow { get { return this.currentFlow; } }
    }
}
