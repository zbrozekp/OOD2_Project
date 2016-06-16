using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class Board
    {
        List<Component> theComponents;
        List<Pipeline> thePipelines;

        public Board()
        {
            this.theComponents = new List<Component>();
        }

        public void addComponent(Component newComponent, int posx, int posy)
        {
            Component temp = new Component(posx, posy);
            this.theComponents.Add(temp);
        }

        public void removeComponent(Component component)
        {
            this.theComponents.Remove(component);
        }

        public Component findComponent(int posx, int posy)
        {
            foreach (Component c in this.theComponents)
            {
                if(c.getPosX < posx && c.getPosX + 50 > posx && c.getPosY < posy && c.getPosY + 50 > posy)
                {
                    return c;
                }
            }
            return null;
        }

        public void updateHighlight(Component component)
        {

        }

        public void addPipeline(Pipeline pipe)
        {
            Pipeline temp = new Pipeline();
            this.thePipelines.Add(temp);
        }

        public void removePipeline(Pipeline pipe)
        {
            this.thePipelines.Remove(pipe);
        }

        //public Pipeline findPipeline()
    }
}
