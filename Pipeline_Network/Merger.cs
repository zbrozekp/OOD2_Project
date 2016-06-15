using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class Merger
    {
        Pipeline input1;
        Pipeline input2;
        Pipeline output;
        
        public double calculateFlow()
        {
            double temp = input1.getCurrentFlow + input2.getCurrentFlow;
            return temp;
        }

        public void changeConnections(Pipeline newInput1, Pipeline newInput2, Pipeline newOutput)
        {
            this.input1 = newInput1;
            this.input2 = newInput2;
            this.output = newOutput;
        }

    }
}
