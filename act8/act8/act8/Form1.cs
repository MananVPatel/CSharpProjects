//Manan Patel
//CMPSC 302
//02/09/2016
//Activity 08


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

namespace act8
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
            StreamReader fileIn = File.OpenText("salesdata.txt");
            StreamWriter goodParts = new StreamWriter("valid.txt");
            StreamWriter badParts = new StreamWriter("invalid.txt");

            //create an object for the partValidator class
            partValidator p = new partValidator();
           
            //local variables
            String lineIn; //holds each line from the file salesdata.txt
            string partNo, desc;
            int quantity;
            string lineOut = string.Empty; // line that will be written out to a file
            double price; 
            double extension;
            double total = 0;

            //counters for good and bad files and all files
            int goodPartCount = 0;
            int badPartCount = 0;
            int allCount = 0;

            if (File.Exists("salesdata.txt"))
            {
                //file exists
                textBox2.Text = "Manan Patel"; // write name out to textbox2

                //read each line from file
                while (!fileIn.EndOfStream)
                {
                    lineIn = fileIn.ReadLine();
                    string[] splitter = lineIn.Split(','); //split the line at the comma char

                    //assingments of each element of the splitter array
                    partNo = splitter[0]; 
                    desc = splitter[1];
                    quantity = Convert.ToInt32(splitter[2]);
                    price = Convert.ToDouble(splitter[3]);
                    
                    //re create the line to writeout to a file
                    for(int i = 0; i < splitter.Length; i++)
                    {
                        lineOut += splitter[i] + " ";
                        Console.WriteLine(lineOut);
                    }
                    
                    //if the part no is valid, execute if loop
                    if(p.isValid(partNo))
                    {
                        goodPartCount++; //counds good records
                        extension = quantity * price; //calculate price for this part
                        total += extension; //add to total
                        writeFile(lineOut, goodParts); //write it out to valid.txt
                    }

                    //otherwise, execute else loop
                    else
                    {
                        badPartCount++;  //counts bad records
                        writeFile(lineOut, badParts); //write the line out to invalid.txt
                    }

                    allCount++; //counts all the records
                    lineOut = string.Empty;
                }

                //print info to the txtInfo textbox 
                txtInfo.Text = "Total Good Records = " + goodPartCount + Environment.NewLine;
                txtInfo.AppendText("Total Bad Records = " + badPartCount + Environment.NewLine);
                txtInfo.AppendText("Total Records = " + allCount + Environment.NewLine);
                txtInfo.AppendText("Total Sales = $" + total + Environment.NewLine);
            }

            //close all files
            goodParts.Close();
            badParts.Close();
            fileIn.Close();
        }

    //writes out the passed in line to the passed in text file
    private void writeFile(String line, StreamWriter fileOut)
    {
        fileOut.WriteLine(line);
    }

    //closes the form
    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    }
}
