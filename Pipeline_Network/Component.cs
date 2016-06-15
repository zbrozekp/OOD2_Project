using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class Component
    {
        int posx;
        int posy;
        bool isClicked;
        List<AnchorPoint> theAnchorPoints;
        //List<Image> theImages;
        List<Pipeline> thePipelines;

        public Component(int x, int y)
        {
            this.posx = x;
            this.posy = y;
            this.isClicked = false;
            this.theAnchorPoints = new List<AnchorPoint>();
            //this.theImages = new List<Image>();
            this.thePipelines = new List<Pipeline>();
        }
        
        public void changeTexture(int textureId) //nie int tylko Pen?
        {

        }

        public void changePosition(int newPosX, int newPosY)
        {
            this.posx = newPosX;
            this.posy = newPosY;
        }

        public int getPosX { get { return this.posx; } }

        public int getPosY { get { return this.posy; } }

        public bool getIsClicked { get { return this.isClicked; } }

        //public AnchorPoint findAnchorPoint(int posx, int posy) { }

        public void addPipeline(Pipeline newPipeline)
        {
            this.thePipelines.Add(newPipeline);
        }

        //public AnchorPoint findSelectedAnchor() { }
    }
}
