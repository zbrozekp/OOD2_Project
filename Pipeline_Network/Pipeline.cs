using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class Pipeline
    {
        double currentFlow;
        double maxCapacity;
        Component connection1;
        Component connection2;

        public Pipeline()
        {
            this.currentFlow = 0;
            this.maxCapacity = 0;
        }

        public Pipeline(double initialMaxCapacity)
        {
            this.currentFlow = 0;
            this.maxCapacity = initialMaxCapacity;
        }

        public void alterPipeline(double newMaxCapacity)
        {
            this.maxCapacity = newMaxCapacity;
        }

        public void addNeighbours(Component con1, Component con2)
        {
            this.connection1 = con1;
            this.connection2 = con2;
        }


        public void updateFlow(double newCurrentFlow)
        {
            this.currentFlow = newCurrentFlow;
        }

        public double getCurrentFlow { get { return this.currentFlow; } }
    }
}
