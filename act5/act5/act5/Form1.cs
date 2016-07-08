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

namespace act5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SalesStruct> salesList = new List<SalesStruct>(); 
        
        public struct SalesStruct
        {
            public string ID;
            public String sales;

            //public SalesStruct(String _ID, Decimal _sales)
            //{
            //    ID = _ID;
            //    sales = _sales;
            //}

            public override string ToString()
            {
                return base.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            readFile(); //call readfile to extract info from the febsales.txt
            //local variables
            String timeString;
            String autoString;
            
            //counters
            int ftCount = 0;
            int ptCount = 0;
            int usedCount = 0;
            int newCount = 0;

            //adders 
            double totalSalesft = 0;
            double totalSalespt = 0;
            double totalSalesUsed = 0;
            double totalSalesNew = 0;

            foreach (SalesStruct sale in salesList)
            {
                //gets the first digit of the ID, either F(full time) or P(part time)
                timeString = sale.ID.Substring(0, 1);
                
                //full time sales man
                if (timeString == "F")
                {
                    ftCount++; //counts the # of cars sold by full time employees
                    totalSalesft += Convert.ToDouble(sale.sales.Substring(0)); //adds up the price of the cars
                }

                // part time sales man
                else if(timeString == "P")
                {
                    ptCount++; //counts the # of cars sold by part time employees
                    totalSalespt += Convert.ToDouble(sale.sales.Substring(0));//adds up the price of the cars
                }

                // gets the last digit of the ID, either 1 or 2
                autoString = sale.ID.Substring(3, 1); 

                //new car sales man
                if (autoString == "1")
                {
                    newCount++; //counts the number of new cars sold
                    totalSalesNew += Convert.ToDouble(sale.sales.Substring(0)); //adds up the price of the new cars
                }
                //used car salesman
                else if (autoString == "2")
                {
                    usedCount++; //counts the number of used cars sold
                    totalSalesUsed += Convert.ToDouble(sale.sales.Substring(0)); //adds up the price of the used cars         
                }

            }

            //Populate all labels by sending the correct info to the function
            populateLabels(numFull, Convert.ToString(ftCount));
            populateLabels(numPart, Convert.ToString(ptCount));
            populateLabels(numNew, Convert.ToString(newCount));
            populateLabels(numUsed, Convert.ToString(usedCount));
            populateLabels(totalFull, Convert.ToString(totalSalesft));
            populateLabels(totalPart, Convert.ToString(totalSalespt));
            populateLabels(totalNew, Convert.ToString(totalSalesNew));
            populateLabels(totalUsed, Convert.ToString(totalSalesUsed));
        }

        //assigns a string to a label.text
        private void populateLabels(Label l, string t)
        {
            l.Text = t;
        }

        //reads the febsales.txt file and copies the content into a list via SalesStruct
        private void readFile()
        {
            //read and open file
            StreamReader fileIn = File.OpenText("febsales.txt");

            //holds the contents of each line in the file
            String[] splitter = new String[2];

            SalesStruct s = new SalesStruct();
            String lineIn;
           
            if(File.Exists("febsales.txt"))
            {
                //exists
                while (!fileIn.EndOfStream)
                {
                    lineIn = fileIn.ReadLine();
                    splitter = lineIn.Split(' ');
                    s.ID = splitter[0];
                    s.sales = splitter[1];
                    salesList.Add(s);
                }
            }

            //if no file, show an error
            else
            {
                MessageBox.Show("Not able to open file!");
            }
            fileIn.Close(); // close the file
        }

        //Calculate Button
        private void bCalc_Click(object sender, EventArgs e)
        {
            string IDval; 

            //check if ID is correct
            if(isValidID(txtID.Text))
            {

                IDval = txtID.Text;// gets the user input
                string txtSubString = IDval.Substring(1, 2); //holds the initials of the employee
                int countEmp = 0;
                double empTotal = 0;

                foreach (SalesStruct s in salesList)
                {
                    //see if the intials entered exist in the SalesList
                    if (txtSubString == s.ID.Substring(1, 2))
                    {
                        countEmp++;
                        empTotal += Convert.ToDouble(s.sales.Substring(0));
                    }
                }

                // place info from above into the labels
                populateLabels(numAssociate, Convert.ToString(countEmp));
                populateLabels(totalAssociate, Convert.ToString(empTotal));
            }
            
            // If Id is not correct, execute else statement
            else
            {
                txtID.Text = "Invalid ID!";
                txtID.Focus();
                txtID.BackColor = Color.Red;
            }
            
            
           
        }

        //checks if the form of the ID is correct
        private bool isValidID(string testID)
        {
            bool OK = false;
            string pattern = @"^[PF][A-Z]{2}[12]$";
            Regex id = new Regex(pattern);
            if (id.IsMatch(testID))
                OK = true;
            return OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
