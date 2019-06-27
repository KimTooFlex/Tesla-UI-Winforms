using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesla_UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(0);
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(1);
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(2);
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(3);
        }

        private void BunifuFlatButton8_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(4);
        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(5);
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(6);
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(7);
        }

        private void BunifuFlatButton10_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(8);
        }

        private void BunifuFlatButton9_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(9);
        }

        private void BunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            lbBrightness.Text = $"Display Brightness ({e.Value}%)";
        }

        private void Label36_Click(object sender, EventArgs e)
        {
            bunifuHSlider2.Value = 0;
        }

        private void Label37_Click(object sender, EventArgs e)
        {
            bunifuHSlider2.Value = 1;
        }

        private void Label41_Click(object sender, EventArgs e)
        {
            bunifuHSlider3.Value = 0;
        }

        private void Label40_Click(object sender, EventArgs e)
        {
            bunifuHSlider3.Value = 1;
        }

        private void Label42_Click(object sender, EventArgs e)
        {
            bunifuHSlider3.Value = 2;
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            //push
            Random r = new Random();
            for (int i = 0; i < 7; i++)
            {
                gridTrips.Rows.Add(
                   new object[]
                   {
                    "",
                    "Trip "+i,
                     r.Next(10,100)+"Miles",
                     r.Next(1,10)+"Hours",
                     r.Next(10,100)+"Kw/H",
                   }
                   );
            }
        }
    }
}
