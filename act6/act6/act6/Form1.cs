//Manan Patel
//CMPSC 302
//2/2/2016
//11:31 AM 
//Activity 6

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Read the file entered in the textbox
        private void bRead_Click(object sender, EventArgs e)
        {
            string fileName, lineIN;
            fileName = txtFile.Text; //get file name from text box
            
            bool OK = File.Exists(fileName); //check if file exists
            if (OK)
            {
                //file exists
                lineIN = File.ReadAllText(fileName); //read all info from the file
                Validate(lineIN); //send the info to the validate function
            }
            
            // if file doesn't exist show error message
            else
            {
                txtFile.Text = "File Not read! Doesn't Exist!";
                txtFile.Focus();
                txtFile.BackColor = Color.AliceBlue;
            }
        }

        //validate the string being passed in via the adler_32 class object
        private void Validate(string s)
        {
            Adler_32 a = new Adler_32(s);
            label1.Text = a.adlerNumber();
        }
    }
}
