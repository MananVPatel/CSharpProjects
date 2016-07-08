using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPartValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //transfers the contents of the textbox to the list
        private void btnStore_Click(object sender, EventArgs e)
        {
            //if the vehicle ID number is correct, add it to the 
            if(partValidator1.BackColor == Color.LightGreen)
            {
                string getNum = partValidator1.Text;
                listBox1.Items.Add(getNum);
            }
            
        }
    }
}
