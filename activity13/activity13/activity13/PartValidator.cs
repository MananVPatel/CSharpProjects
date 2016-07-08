using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity13
{
    public partial class PartValidator: TextBox
    {
        public PartValidator()
        {
            InitializeComponent();
        }

        private void PartValidator_Leave(object sender, EventArgs e)
        {
            Validate v = new Validate(this.Text);

            //if the vehicle ID number is valid
            if (v.isValid())
            {
                //change back color to light green
                this.BackColor = Color.LightGreen;
            }           
            else
            {
                //otherwise change color to yellow, give it focus
                this.BackColor = Color.Yellow;
                this.Focus();
                this.Text += " is NOT Valid! Re-Enter!";
            }
        }
    }
}
