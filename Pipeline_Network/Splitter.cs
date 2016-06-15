using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class Splitter
    {
        Pipeline input;
        Pipeline output1;
        Pipeline output2;

        public double calculateFlow(double currentFlow)
        {
            double temp = currentFlow / 2;
            return temp;
        }

        public void changeConnections(Pipeline newInput, Pipeline newOutput1, Pipeline newOutput2)
        {
            this.input = newInput;
            this.output1 = newOutput1;
            this.output2 = newOutput2;
        }
    }
}
