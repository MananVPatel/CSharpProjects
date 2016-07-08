//Manan Patel
//02/04/2016
//CMPSC 302
//Activity 7


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //stores the contents of the dictionary.txt file
        List<String> wordList = new List<String>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StreamReader fileIn = File.OpenText("dictionary.txt");
            String lineIn;

            if (File.Exists("dictionary.txt"))
            {
                textBox1.Text = "Successfully read File!";//output to the textbox
               
                //read each line from file and put it in the wordList
                while (!fileIn.EndOfStream)
                {
                    lineIn = fileIn.ReadLine();
                    wordList.Add(lineIn);
                }

                //create a pattern for comparing
                string pattern = @"^[^aeiouyAEIOUY]+$"; 
                Regex r = new Regex(pattern); //regex function

                //loop for checking each line of the list
                foreach(string w in wordList)
                {
                    //the string that matches the pattern above, print that string in the list
                    if(r.IsMatch(w))
                    {
                        lBox.Items.Add(w);
                    }
                }
            }

           //if file doesnt exist, show an error message
            else
            {
                MessageBox.Show("Not able to open file!");
            }
            fileIn.Close(); // close file
        }

        //close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
