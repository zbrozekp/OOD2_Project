using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class Sink
    {
        double currentFlow;
        Pipeline input;

        public void changeConnections(Pipeline newInput)
        {
            this.input = newInput;
        }

        public void updateFlow(double newCurrentFlow)
        {
            this.currentFlow = newCurrentFlow;
        }

        public double getCurrentFlow { get { return this.currentFlow; } }
    }
}
