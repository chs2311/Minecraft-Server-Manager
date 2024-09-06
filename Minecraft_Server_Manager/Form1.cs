using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            roundedButton1.Image = new Bitmap(Image.FromFile("in_objects\\icons\\newinst\\0"), new Size(32, 32));
            roundedButton2.Image = new Bitmap(Image.FromFile("in_objects\\icons\\backup\\0"), new Size(32, 32));
            roundedButton3.Image = new Bitmap(Image.FromFile("in_objects\\icons\\import\\0"), new Size(32, 32));
            roundedButton4.Image = new Bitmap(Image.FromFile("in_objects\\icons\\help\\0"), new Size(32, 32));
        }

        private void newServerClick(object sender, EventArgs e)
        {

        }

        private void backupClick(object sender, EventArgs e)
        {

        }

        private void importClick(object sender, EventArgs e)
        {

        }

        private void helpClick(object sender, EventArgs e)
        {

        }
    }
}
