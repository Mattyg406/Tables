using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace corucitboolean
{
    public partial class Component : UserControl
    {
        public string compType;
        public Label compLabel;
        public int compID;
        public Component(int i, string T, int posx, int posy)
        {
            InitializeComponent();
            this.Top = posy;
            this.Left = posx;
            compType = T.ToUpper();
            compID = i;
            compLabel = label1;
            compLabel.Text = compID.ToString();       
        }
        public Component(IContainer container)
        {
            container.Add(this);
        }
        Point point;
        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.X;
            }
            base.OnMouseMove(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          


        }
    }
}
