using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint1
{
    public partial class PoolCalculator : Form
    {
        // setting constants for later use
        const int LENGTHCEILING = 5;
        const int LENGTHFLOOR = 50;
        const int WIDTHCEILING = 2;
        const int WIDTHFLOOR = 20;
        const int AVGDEPTHCEILING = 2;
        const int AVGDEPTHFLOOR = 4;
        const int CATSMALL = 500000;
        const int CATLARGE = 1500000;
        const int TEMPCONST = 25;
        const int CALCONST = 32500;
        const int THOUCONST = 1000;
        public PoolCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private bool ValidLength(float length) //test whether length is valid
        {
            bool validLength;
            if (length >= LENGTHCEILING && length <= LENGTHFLOOR)
            {
                validLength = true;
            }
            else
            {
                validLength = false;
                MessageBox.Show("Length measurement is invalid \r\nPlease enter a value between 5 and 50");
            }
            return validLength;
        }

        private bool ValidWidth(float width) //test whether width is valid
        {
            bool validWidth;
            if (width >= WIDTHCEILING && width <= WIDTHFLOOR)
            {
                validWidth = true;
            }
            else
            {
                validWidth = false;
                MessageBox.Show("Width measurement is invalid \r\nPlease enter a value between 2 and 20");
            }
            return validWidth;
        }

        private bool ValidAvgDepth(float avgDepth) //test whether avgdepth is valid
        {
            bool validAvgDepth = false;
            if (avgDepth >= AVGDEPTHCEILING && avgDepth <= AVGDEPTHFLOOR)
            {
                validAvgDepth = true;
            }
            else
            {
                validAvgDepth = false;
                MessageBox.Show("Average depth is invalid \r\nPlease enter a value between 2 and 4");
            }
            return validAvgDepth;
        }

        private float CalcArea() //calculate surface area
        {
            float area = 0;
            area = float.Parse(txtLength.Text) * float.Parse(txtWidth.Text);
            return area;
        }

        private float CalcVol() //calculate volume
        {
            float volume = 0;
            volume = float.Parse(txtLength.Text) * float.Parse(txtWidth.Text) * float.Parse(txtAvgDepth.Text) * THOUCONST;
            return volume;
        }

        private string Category() //determine pool category
        {
            string cat = "";
            float vol = CalcVol();
            if (vol <= CATSMALL)
            {
                cat = "Pool Category: Small";
            }
            else if (vol > CATSMALL && vol <= CATLARGE)
            {
                cat = "Pool Category: Medium";
            }
            else if (vol > CATLARGE)
            {
                cat = "Pool Category: Large";
            }
            return cat;
        }
        private void btnCalculate_Click(object sender, EventArgs e) //event of clicking Calculate botton
        {
            if (!(ValidLength(float.Parse(txtLength.Text))))
            {
                return;
            }
            else if (!(ValidWidth(float.Parse(txtWidth.Text))))
            {
                return;
            }
            else if (!(ValidAvgDepth(float.Parse(txtAvgDepth.Text))))
            {
                return;
            } //determine whether all inputs are valid
            else
            {
                txtSurfaceArea.Text = CalcArea().ToString();
                txtVolume.Text = CalcVol().ToString();
                lblCategory.Text = Category(); //if all valid, output results to certain text boxes
            }

            float temp = 5;
            int cost;
            while (temp <= 23)
            {
                txtTableAvgTemp.Text += temp + "\r\n";
                cost = (int)Math.Floor((TEMPCONST - temp) * CalcVol()/CALCONST);
                txtTableDollars.Text += cost + "\r\n";
                temp += (float)1.5;
            } //list average temperature and requqired dollar per month for current pool

        }

        private void btnExit_Click(object sender, EventArgs e) //close the program when clicking exit button
        {
            Application.Exit();
        }
    }
}
