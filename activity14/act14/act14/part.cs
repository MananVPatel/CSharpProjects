using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act14
{
    public partial class part: TextBox
    {
        public part()
        {
            InitializeComponent();
        }
        private bool _Suffix = false;
        private void part_Leave(object sender, EventArgs e)
        {
            validation v = new validation(this.Text, allowSuffix);

            if (v.isValid())
            {
                this.BackColor = Color.LightGreen;
            }
            else
            {
                this.BackColor = Color.Yellow;
                this.Focus();
                this.Text += " is Not Valid! Please Re-Enter!";
            }
        }
        public bool allowSuffix
        {
            get { return _Suffix; }
            set { _Suffix = value; }
        }


    }
}
