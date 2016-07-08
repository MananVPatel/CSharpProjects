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

namespace act10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            //reading and writing from and to different files
            StreamReader fileIn = new StreamReader("presenter.txt");
            StreamWriter fileOut = new StreamWriter("validList.txt");

            //local variables
            string psmlaCode, paypalCode;
            string amount;
            string lineIn; //holds each line from the file presenter.txt
            string lineOut = string.Empty; // lineout adds to the 

            //patterns for each of the regex functions 
            string paypalCodePattern = @"(?<prefix>value="")(?<pcode>[A-Z0-9]{13})(?<suffix>"" ?/?>)";
            string amountPattern = @"\b(?<amount>\d*\.\d\d)\b";
            string psmlaCodePattern = @"(?<prefix><!-- ?)(?<code>[A-Z]{5})(?<suffix> ?-->)";

            //regex functions
            Regex r1 = new Regex(psmlaCodePattern);
            Regex r2 = new Regex(amountPattern);
            Regex r3 = new Regex(paypalCodePattern);

            //if file exists, create a list of the PSMLA code, paypal code, and amount
            if (File.Exists("presenter.txt"))
            {               
                //open the presenter file for reading
                fileIn = File.OpenText("presenter.txt");
                //read each line from file
                while (!fileIn.EndOfStream)
                {
                    //read in each line from the file
                    lineIn = fileIn.ReadLine();

                    //check if the pattern in regex function r1 matches the line being processed
                    foreach(Match mat1 in r1.Matches(lineIn))
                    {
                        //gets the collection of matches and converts it to a string
                        psmlaCode = mat1.Groups["code"].ToString();
                        lineOut = psmlaCode;
                    }

                    //check if the pattern in regex function r2 matches the line being processed
                    foreach (Match mat2 in r2.Matches(lineIn))
                    {
                        //gets the collection of matches and converts it to a string
                        amount = mat2.Groups["amount"].ToString();
                        lineOut += ("\t\t" + amount);
                    }
                    
                    //check if the pattern in regex function r3 matches the line being processed
                    foreach (Match mat3 in r3.Matches(lineIn))
                    {
                        //gets the collection of matches and converts it to a string
                        paypalCode = mat3.Groups["pcode"].ToString();
                        lineOut += ("\t\t" + paypalCode);
                        //send fileout and lineout to write to file function
                        writeToFile(fileOut, lineOut);
                        //write the created line to the textbox
                    }
                }
                label1.Text = "Written to the ValidList.txt file!";
                //close both files
                fileIn.Close();
                fileOut.Close();
            }
             
            //if file doesn't exist, tell user
            else
            {
                label1.Text = "Not able to Open file!";
            }

        }

        //writes out a passed in line to a passed in file 
        private void writeToFile(StreamWriter file, string line)
        {
            file.WriteLine(line);
        }

        //closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
