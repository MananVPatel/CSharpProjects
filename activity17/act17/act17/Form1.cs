// Manan Patel
// CMPSC 302
// 3/24/2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act17
{
    public partial class Form1 : Form
    {

        public List<Button> buttons = new List<Button>(); //list of buttons
        const int ub = 10; //the number of buttons
        const int ButtonHW = 35; //holds the height and width of the buttons
        public int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i, j, row;
            Point pntCurrent;
            row = 4;
            j = 0;

            for (i = 0; i < ub; i++)
            {
                j = i % ((ub + 1) / 3) + 2;
                if (i % (ub/3) == 0)
                {
                    row += (ButtonHW + 5);
                }

                pntCurrent = new Point(j * (ButtonHW + 8), row);
                createButton(i, pntCurrent);
            }
            //for each button create an eventhandler when clicked
            for (int k = 0; k<buttons.Count; k++)
            {
                this.buttons[k].Click += new EventHandler(buttonClick);
            }
        }

        //creates and shows buttons on the form
        private void createButton(int i, Point pntCurrent)
        {
            buttons.Add(new Button());
            buttons[i].Enabled = true;
            buttons[i].Visible = true;              
            if (i % 2 == 0)
                buttons[i].BackColor = Color.CadetBlue;
            else
                buttons[i].BackColor = Color.Chocolate;
 
            buttons[i].Text = Convert.ToString((i + 1) % 10);
            buttons[i].Size = new System.Drawing.Size(ButtonHW, ButtonHW);
            buttons[i].Location = pntCurrent;
            this.Controls.Add(buttons[i]);
        }

        //when the button is clicked 
        private void buttonClick(object sender, EventArgs e)
        {
            string s;
            Button b = sender as Button;
            s = b.Text;
            n += Convert.ToInt32(s); // adds the buttons clicked
            label1.Text = n.ToString();
            
        }


        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clears the label
        private void bClear_Click(object sender, EventArgs e)
        {
            n = 0;
            label1.Text = n.ToString();
        }
    }
}
