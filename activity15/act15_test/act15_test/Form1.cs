// MANAN PATEL
// 3/17/2016
// CMPSC 302
//Activity 15




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act15_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //process button
        private void bProcess_Click(object sender, EventArgs e)
        {
            //if the checkbox is checked, copy the textbox content into the listbox
            if (userControl11.chkValid.Checked)
            {
                listBox1.Items.Add(userControl11.validItem);
            }
        }

        //exit button, closes the form
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
