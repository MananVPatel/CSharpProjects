//Manan Patel
//CMPSC 302
//5/4/2016
//Final Project - Deal or No Deal


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

namespace DealOrNoDeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*--------------> global variables <------------*/
        List<String> list = new List<String>();
        Random rand = new Random();
        int counter = 0;
        int totalAmount = 0;

        //counter for the game
        int firstround = 7;
        int secondround = 6;
        int thirdround = 4;
        int fourthround = 3;
        int fifthround = 2;
        int sixthround = 1;
        int seventhround = 1;
        int currentRound = 1;

        Button yourBriefcase;
        double offer;
        String currency;

        //form_load
        private void Form1_Load(object sender, EventArgs e)
        {
            //disable deal and no deal buttons
            btnDeal.Enabled = false;
            btnNoDeal.Enabled = false;
            
            //local variables
            string line;
            int index = 0;
            string fileName = "dollarAmounts.txt";
            StreamReader file;

            //A list that holds the briefcase buttons on the form
            List<Button> buttons = new List<Button> { button1, button2, button3, button4, 
                button5, button6, button7, button8, button9, button10, button11, button12,
                button13, button14, button15, button16, button17, button18, button19, 
                button20, button21, button22, button23, button24, button25, button26};

            //A list that holds the amount value labels on the form
            List<Label> labels = new List<Label> {label1, label2, label3, label4, label5, label6, label7, 
                label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18,
                label19, label20, label21, label22, label23, label24, label25, label26};

            //open the file for reading
            file = File.OpenText(fileName);

            if (File.Exists(fileName))
            {
                //file exists

                //read in the contents of the file and store in the List "list".
                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    list.Add(line);
                }

                //for each element in the List "list", convert it to currency and assign to a label
                foreach (Control label in labels)
                {
                    int value = Convert.ToInt32(list[index]);
                    label.Text = String.Format("{0:C0}", value);
                    index++;
                }

                //create an eventhandler for the buttons in the List "buttons"
                foreach (Control button in buttons)
                {
                    button.Click += new EventHandler(this.button_Click);
                }
                lblNarate.Text = "Choose Your Briefcase";
            }

            //if file does not exist...
            else
            {
                MessageBox.Show("Not able to open file!");
            }

            //close file;
            file.Close();
        }

        //event handler for the button click
        private void button_Click(object sender, EventArgs e)
        {
            //access button as a sender
            Button btn = sender as Button;

            //local variables
            int value;
            counter++; // counts the amount of buttons clicked

            //store the first button as one chosen by the user
            if (counter == 1)
            {
                yourBriefcase = btn;
                yourBriefcase.Image = ((System.Drawing.Image)(Properties.Resources.img1));
                yourBriefcase.Enabled = false;
            }
            //otherwise
            else
            {
                //create and object of form ShowValue 
                ShowValue briefValue = new ShowValue();

                //shuffle the list to get a random value;
                Shuffle(list);

                value = Convert.ToInt32(list[0]);

                //convert the value of the list element to a currenct value
                currency = String.Format("{0:C0}", value);

                //compare the opened box value with the label value, if they match then change the color of those labels
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        if (currency == c.Text)
                        {
                            c.BackColor = Color.LightYellow;
                            c.ForeColor = Color.LightGray;
                        }
                    }
                }

                //this assigns the randomly choosen value to the Showform label
                briefValue.label1.Text = currency;
                briefValue.ShowDialog(); //shows the form that I created an object of 
                list.RemoveAt(0); // removes the element so, it is not used again
                btn.Visible = false; //make the button invisible after it has been clicked
            }

            //switches through the different rounds of the game and tells user to choose certain amount of boxes
            switch (currentRound)
            {
                //choose 7 briefcases and choose deal or no deal
                case 1:
                    lblNarate.Text = "Choose " + firstround + " BriefCases";
                    firstround--;

                    if (firstround == -1)
                    {
                        MessageBox.Show("Banker Has Made an Offer!");
                        DisableButtons(); // disable all the buttons
                        bankerOffer(getTotal(), counter, 1); //get the bankers offer
                        MessageBox.Show("Choose Deal or No Deal");
                        currentRound = 2; //go to the next round
                        lblNarate.Text = "Choose " + secondround + " BriefCases";
                    }
                    break;

                //choose 6 briefcases and choose deal or no deal
                case 2:

                    secondround--; //count dowm
                    lblNarate.Text = "Choose " + secondround + " BriefCases";
                    if (secondround == 0)
                    {
                        MessageBox.Show("Banker Has Made an Offer!");
                        DisableButtons();
                        bankerOffer(getTotal(), counter, 2);
                        MessageBox.Show("Choose Deal or No Deal");
                        currentRound = 3; //go to the next round
                        lblNarate.Text = "Choose " + thirdround + " BriefCases";
                    }
                    break;
                
                //choose 4 briefcases and choose deal or no deal
                case 3:
                    thirdround--;
                    lblNarate.Text = "Choose " + thirdround + " BriefCases";

                    if (thirdround == 0)
                    {
                        MessageBox.Show("Banker Has Made an Offer!");
                        DisableButtons();
                        bankerOffer(getTotal(), counter, 3);
                        MessageBox.Show("Choose Deal or No Deal");
                        currentRound = 4;
                        lblNarate.Text = "Choose " + fourthround + " BriefCases";
                    }
                    break;

                //choose 3 briefcases and choose deal or no deal
                case 4:
                    fourthround--;//count down
                    lblNarate.Text = "Choose " + fourthround + " BriefCases";

                    if (fourthround == 0)
                    {
                        MessageBox.Show("Banker Has Made an Offer!");
                        DisableButtons();
                        bankerOffer(getTotal(), counter, 4);
                        MessageBox.Show("Choose Deal or No Deal");
                        currentRound = 5;
                        lblNarate.Text = "Choose " + fifthround + " BriefCases";
                    }
                    break;

                //choose 2 briefcases and choose deal or no deal
                case 5:
                    fifthround--;
                    lblNarate.Text = "Choose " + fifthround + " BriefCases";

                    if (fifthround == 0)
                    {
                        MessageBox.Show("Banker Has Made an Offer!");
                        DisableButtons();
                        bankerOffer(getTotal(), counter, 5);
                        MessageBox.Show("Choose Deal or No Deal");
                        currentRound = 6;
                        lblNarate.Text = "Choose " + sixthround + " BriefCases";
                    }
                    break;
                //choose 1 briefcase and choose deal or no deal
                case 6:
                    sixthround--;
                    lblNarate.Text = "Choose " + sixthround + " BriefCases";

                    if (sixthround == 0)
                    {
                        MessageBox.Show("Banker Has Made an Offer!");
                        DisableButtons();
                        bankerOffer(getTotal(), counter, 6);
                        MessageBox.Show("Choose Deal or No Deal");
                        currentRound = 7;
                        lblNarate.Text = "Choose " + seventhround + " BriefCases";
                    }
                    break;

                  //choose one more briefcase and choose deal or no deal
                case 7:
                    seventhround--;
                    lblNarate.Text = "Choose " + seventhround + " BriefCases";

                    if (seventhround == 0)
                    {
                        MessageBox.Show("Banker Has Made an Offer!");
                        DisableButtons();
                        bankerOffer(getTotal(), counter, 6);
                        MessageBox.Show("Choose Deal or No Deal");
                        currentRound = 8;
                        lblNarate.Text = "Choose Between Two Briefcases";
                    }          
                    break;

                //choose between the two buttons for the prize amount 
                case 8:
                    yourBriefcase.Enabled = true;
                    lblNarate.Text = "You Picked Case #: " + btn.Text + " with " + currency;
                    MessageBox.Show("Good Game!");
                    this.Dispose();


                    break;
            }  
        }

        //shuffles the list that is passed in, to randomize the distribution of values
        void Shuffle(List<String> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);

                //swap the values
                String value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        //sums the values that have not been opened yet
        int getTotal()
        {
            int totalAmount = 0;
            foreach (String s in list)
            {
                totalAmount += Convert.ToInt32(s);
            }
            Console.WriteLine(totalAmount);
            return totalAmount;
        }

        // generates a value for the bankers offer
        void bankerOffer(int currentTotal, int count, int round)
        {
            //enables the deal or no deal buttons for user to make a choice 
            btnDeal.Enabled = true;
            btnNoDeal.Enabled = true;

            //generating an offer based on values being passed in
            offer = (((currentTotal / (27 - count)) * round) / 10);
            
            //converting it to a currency amount and printing it in a label
            lblNarate.Text = "Banker Offer: " + String.Format("{0:C0}", offer);
            
            //adds the bankers offer to a list of previous offers 
            listBox1.Items.Add(String.Format("{0:C0}", offer));
        }

        //button click event handler for the deal button
        private void btnDeal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GAME OVER!");
            this.Dispose();
        }

        //button click event handler for the no deal button
        private void btnNoDeal_Click(object sender, EventArgs e)
        {
            EnableButtons();
            MessageBox.Show("OFFER DECLINED!");

            if(counter > 24)
            {
                yourBriefcase.Enabled = true;
            }

            //disables the button once clicked
            btnDeal.Enabled = false;
            btnNoDeal.Enabled = false;
        }

        //disable buttons while the banker gives an offer, except for deal or no deal
        void DisableButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    if (c.Text != btnDeal.Name && c.Text != btnNoDeal.Name)
                    {
                        c.Enabled = false;
                    }
                }
            }
        }

        //enables buttons after the bankers offer
        void EnableButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    c.Enabled = true;
                    yourBriefcase.Enabled = false;
                }
            }
        }
    }
}
