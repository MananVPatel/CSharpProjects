// Manan Patel
// CMPSC 302
// 04/05/2016
// Activity 21

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //prints the reversed string into the label
        private void bRev_Click(object sender, EventArgs e)
        {
            label1.Text = reverse(textBox1.Text);
        }

        //recursive algorithm to reverse a string
        private String reverse(string str)
        {
            if(str.Length > 0)
            {
               return str[str.Length - 1] + reverse(str.Substring(0, str.Length - 1));
            }
            else
            {
                return str;
            }
        }
    }
}
