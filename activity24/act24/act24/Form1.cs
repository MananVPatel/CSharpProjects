//Manan Patel
//Activity 4
//4/19/2016
//CMPSC 302


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //create an object for production worker and assign entered values to the class
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int number = Convert.ToInt32(txtNum.Text);
            int shiftNum = Convert.ToInt32(txtShiftNum.Text);
            double hourlyRate = Convert.ToDouble(txtHourly.Text);
            if (name != null && number > 0 && (shiftNum == 1 || shiftNum == 2) && hourlyRate > 0.0)
            {
                ProductionWorker prodWorker = new ProductionWorker();
                prodWorker.name = name;
                prodWorker.number = number;
                prodWorker.shiftNum = shiftNum;
                prodWorker.hourlyPayRate = hourlyRate;

                //print the info from ProductionWorker class in labels
                if (prodWorker.shiftNum == 1)
                {
                    lblShiftNum.Text = "Day Shift";
                }
                else if (prodWorker.shiftNum == 2)
                {
                    lblShiftNum.Text = "Night Shift";
                }
                else
                {
                    lblShiftNum.Text = "Invalid!";
                }

                lblName.Text = prodWorker.name;
                lblHourly.Text = Convert.ToString(prodWorker.hourlyPayRate);
                lblNum.Text = Convert.ToString(prodWorker.number);
            }


        }
    }
}
