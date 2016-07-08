// MANAN PATEL
// 3/17/2016
// CMPSC 302
//Activity 15

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Act15_ControlLibrary
{
    public partial class UserControl1: UserControl
    {
        //constructor
        public UserControl1()
        {
            InitializeComponent();
            rEmail.Checked = true;
        }

        //private variables
        private string _validItem = string.Empty;

        //evaluate button
        private void bEval_Click(object sender, EventArgs e)
        {
            //local variables
            string p = string.Empty;
            string itemType = string.Empty;
            bool OK;

            //gets the user entry
            string userEntry = textBox1.Text;
            
            //use different patterns depending on which radio button is checked
            if(rEmail.Checked)
            {
                p = @"^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$";
                itemType = "Email";
            }
            else if (rIP.Checked)
            {
                p = @"(^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$)";
                itemType = "IP Address";
            }
            else if (rPart.Checked)
            {
                p = @"^[PD]-(?<first>[268])[0-9]{4}(\k<first>)?(-[0-9]{3})$";
                itemType = "Part Number";
            }

            //send info to validateString function to check if the user entry is in the correct format
            OK = ValidateString(p, userEntry);

            //if the user entry is incorrect do the following
            if(!OK)
            {
                textBox1.BackColor = Color.Yellow;
                textBox1.Focus();
                textBox1.Text = "";
                label2.Text = "You entered " + userEntry + " - That is not a valid " + itemType + " entry!";
                chkValid.Checked = false;            
            }

            // if it is correct, do the following
            else
            {
                textBox1.BackColor = Color.LightGreen;
                chkValid.Checked = true;
                _validItem = textBox1.Text;
                label2.Text = "";
            }
        }

        //public properties, so it could be accessed by the tester
        public string validItem
        {
            get
            {
                return _validItem;
            }
        }

        //validate the user entered text being passed in using regex and compare them with the patterns being passed in
        private bool ValidateString(string p, string text)
        {
            bool OK = false;
            Regex r = new Regex(p);
            if(r.IsMatch(text))
            {
                OK = true;
            }
            return OK;
        }

        //text changed property
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            chkValid.Checked = false;
        }
        
    }
    
}
