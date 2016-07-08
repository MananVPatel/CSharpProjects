using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act12
{
    public partial class Form1 : Form
    {
        //intialize the pot to 200 dollars
        int pot = 200;

        //have one radio button checked at all times
        public Form1()
        {
            InitializeComponent();
            rHigh.Checked = true;
        }

        //closes the forms
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //local variables   
            int payoff = 0;
            string printLine;
            int rolled = rollDie();
            int betAmount;

            //if user bet is valid and bet amount is less than the pot amount
            if (isValid(textBox1.Text) && Convert.ToInt32(textBox1.Text) <= pot)
            {
                //get the user bet amount
                betAmount = Convert.ToInt32(textBox1.Text);

                    //if rolled is equal to seven then payoff is 4:1
                    if (rolled == 7 && rSeven.Checked)
                    {
                        pot = pot - betAmount;
                        payoff = 4 * betAmount;
                    }

                    //if rolled is less than seven or greater than 7, payoff is 1:1
                    else if ((rLow.Checked && rolled < 7) || (rolled > 7 && rHigh.Checked))
                    {
                        pot = pot - betAmount;
                        payoff = 2 * betAmount;
                    }
                    
                    // if no win then subtract betamount from pot
                    else 
                    {
                        pot = pot - betAmount;
                    }

                    //add payoff to pot for winners
                    pot += payoff;
                    
                    //create line to print in the listbox with details refarding each bet
                    printLine = "Bet: " + betAmount + " Rolled: " + rolled + " Pot: " + pot;
                    listBox1.Items.Add(printLine);
                    
                    //if pot goes below 0 or above 500, GAME OVER
                    if (pot == 0 || pot == 500)
                    {
                        listBox1.Items.Add("<<<<********GAME OVER********>>>>");
                    }
                    
                    //Display pot amount after each bet 
                    label2.Text = String.Format("{0:C}", pot);
            }
            
            //if user entry is invalid, give textbox focus and change color
            else
            {
                textBox1.Text = "Invalid Entry!";
                textBox1.Focus();
                textBox1.BackColor = Color.CadetBlue;
            }
        }

        //checks if the string passed into this function is valid by comparing it to the pattern
        private bool isValid(string check)
        {
            bool OK = false;
            string pattern = @"^\d?\d?\d$";
            Regex r = new Regex(pattern);
            if(r.IsMatch(check))
            {
                OK = true;
            }
            return OK;
        }

        //produce random rolling of dies
        private int rollDie()
        {
            int roll;
            Random r = new Random();
            roll = r.Next(1, 7) + r.Next(1, 7);
            return roll;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0:C}", pot);
        }

    }
}
