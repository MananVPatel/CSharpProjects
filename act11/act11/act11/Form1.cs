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

namespace act11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //local variables
            Match m;
            string lineIn; //holds each line from the parts.txt
            string lineOut;
            int number = 10000;
            string getPrefix;
            string suffix;

            //opening files for reading and writing
            StreamReader fileIn = File.OpenText("parts.txt");
            StreamWriter fileOut = new StreamWriter("partsOut.txt");

            //create a regular expression to search each line for matches
            string pattern = @"^((?<first>.{2})[^%.]+)%(?<rest>.+)$";
            Regex r = new Regex(pattern);
            
            
            if (File.Exists("parts.txt"))
            {
                //file exists
                while (!fileIn.EndOfStream)
                {
                    lineIn = fileIn.ReadLine();
                    m = r.Match(lineIn); //get the matches according to patterns
                    
                    //if values exist 
                    if(m.Value != string.Empty)
                    {
                        //get the prefix from the pattern
                       getPrefix = m.Groups["first"].ToString();

                        //if the second character is a space replace with X
                        if(getPrefix[1] == ' ')
                        {
                            getPrefix = getPrefix[0].ToString() + "X";
                        }

                        //find out the prefix for each suffix
                        switch (getPrefix)
                        {
                            case "AA": suffix = "001"; break;
                            case "AB": suffix = "002"; break;
                            case "AC": suffix = "003"; break;
                            case "AN": suffix = "004"; break;
                            case "AX": suffix = "005"; break;
                            case "FX": suffix = "006"; break;
                            case "HS": suffix = "007"; break;
                            default: suffix = "009"; break;
                        }

                        //create a line to send it out to partsOut.txt
                        lineOut = lineIn.Replace(lineIn, getPrefix + '-' + number + '-' + suffix + '%' + m.Groups["rest"].ToString());
                        fileOut.WriteLine(lineOut);

                        //increment each number
                        number++;
                    }
                }
                textBox1.Text = "partsOut.txt has been Updated!";
            }

            //if file doesnt exist, show an error message
            else
            {
                textBox1.Text = "Not able to open file!";
            }
            fileIn.Close(); // close input file
            fileOut.Close(); //close output file
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        }

}
