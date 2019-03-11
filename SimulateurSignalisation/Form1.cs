using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulateurSignalisation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            redstop.Visible = true;
            yellowstop.Visible = false;
            greenstop.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (redstop.Visible == true)
            {
                redstop.Visible = false;
                yellowstop.Visible = false;
                greenstop.Visible = true;
            }

            else if (greenstop.Visible == true)
            {
                redstop.Visible = false;
                yellowstop.Visible =true;
                greenstop.Visible =false;
            }

            else if (yellowstop.Visible == true)
            {
                redstop.Visible = true;
                yellowstop.Visible = false;
                greenstop.Visible = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (yellowstop.Visible == true)
            {
                car.Left = car.Left += 5;
            }

            if (greenstop.Visible == true)
            {
                car.Left = car.Left += 10;
            }
        }
    }
}
