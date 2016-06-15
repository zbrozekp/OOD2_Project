using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline_Network
{
    class AnchorPoint
    {
        int posx;
        int posy;
        bool isClicked;
        //List<Image> theImages;

        public void changePosition(int newPosx, int newPosy)
        {
            this.posx = newPosx;
            this.posy = newPosy;
        }

        public int getPosX { get { return this.posx; } }

        public int getPosY { get { return this.posy; } }

        public bool getIsClicked { get { return this.isClicked; } }

        public void changeTexture(int textureId) //nie int tylko Pen?
        {

        }
    }
}
