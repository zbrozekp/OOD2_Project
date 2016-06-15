using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipeline_Network
{
    public partial class Form1 : Form
    {
        Board drawingBoard;
        Toolbox toolbox;

        public Form1()
        {
            InitializeComponent();
            this.drawingBoard = new Board();
            this.toolbox = new Toolbox();
        }

        public void handleClick(int posx, int posy)
        {

        }

        public void handleDoubleClick(int posx, int posy)
        {

        }

        public bool save()
        {
            return true;
        }

        public bool saveAs()
        {
            return true;
        }

        public bool load()
        {
            return true;
        }

        private void handleButton(System.Windows.Forms.Button componentChosen)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void Pump_Click(object sender, EventArgs e)
        {
        
        }
    }
}
