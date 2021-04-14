using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pr11v6
{
    public partial class Form1 : Form
    {
        ellips[] ellipsis;
        int ElCou = 0;
        int inEll;

        public Form1()
        {
            InitializeComponent();
            ellipsis = new ellips[100];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ElCou >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }
            Graphics graphics = panel1.CreateGraphics();
            inEll = ElCou;

            ellipsis[inEll] = new ellips(graphics, panel1.Height / 2, panel1.Width / 2, 50,35);
            ellipsis[inEll].Show();
            ElCou++;
            cdCircle.Items.Add("Коло №" + (ElCou - 1).ToString());
            cdCircle.SelectedIndex = ElCou - 1;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            ellipsis[inEll].Move(5, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            ellipsis[inEll].Move(-5, 0);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            ellipsis[inEll].Move(0, -5);

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            ellipsis[inEll].Move(0, 5);
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            for(int i = 0; i < 100; i++)
            {
                ellipsis[inEll].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }

        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            for(int i = 0; i<100; i++)
            {
                ellipsis[inEll].Move(0,1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            for(int i = 0; i < 100; i++)
            {
                ellipsis[inEll].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            for(int i = 0; i<100; i++)
            {
                ellipsis[inEll].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            ellipsis[inEll].Expand(4);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            ellipsis[inEll].Colapse(4);
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            ellipsis[inEll].Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inEll = cdCircle.SelectedIndex;
            if (inEll > ElCou || inEll < 0) return;
            ellipsis[inEll].Show();
        }
    }
}
