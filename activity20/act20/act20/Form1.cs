// Manan Patel
// CMPSC 302
// Activity 20
// 4/5/2016

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

namespace act20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //products list declaration, holds the content of the products.txt
        List<Products> prodList = new List<Products>();

        //reads the products.txt and splits the content
        //and puts it into the list using the students class
        private void Form1_Load(object sender, EventArgs e)
        {
            string file = "products.txt";
            string lineIn;           
            StreamReader readFile = File.OpenText(file);
            String[] splitter = new String[4];
            if (File.Exists(file))
            {
                //exists
                while (!readFile.EndOfStream)
                {
                    lineIn = readFile.ReadLine();
                    splitter = lineIn.Split(' ');
                    Products p = new Products();
                    p.Number = splitter[0]; // splits the content
                    p.Description = splitter[1];
                    p.Quantity = splitter[2];
                    p.Price = Convert.ToDecimal(splitter[3]);
                    prodList.Add(p); //add it to the prodList
                }
                readFile.Close();
            }

            //if no file, show an error
            else
            {
                MessageBox.Show("Not able to open file!");
                this.Close();
            }

            //sorts the content of the products.txt in order by description using LINQ
            var query = from aPart in prodList
                        orderby aPart.Description
                        select new
                        {
                            PartNumber = aPart.Number,
                            PartName = aPart.Description,
                            PartOHB = aPart.Quantity,
                            PartPrice = aPart.Price
                        };
            dataGridView1.DataSource = query.ToList();
            readFile.Close(); // close the file
        }

        //sorts the content of the products.txt where price is greater than user entry using LINQ
        private void bGreat_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                var query = from aPart in prodList
                            where aPart.Price > Convert.ToDecimal(textBox1.Text)
                            orderby aPart.Price
                            select new
                            {
                                PartNumber = aPart.Number,
                                PartName = aPart.Description,
                                PartOHB = aPart.Quantity,
                                PartPrice = aPart.Price
                            };
                dataGridView1.DataSource = query.ToList();
            }
            else
            {
                textBox1.Focus();
                textBox1.BackColor = Color.DeepPink;
                textBox1.Text = "Please enter Value!";
            }
        }

        //sorts the content of the products.txt where quantity is less than user entry using LINQ
        private void bLess_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                var query = from aPart in prodList
                            where Convert.ToInt32(aPart.Quantity) < Convert.ToInt32(textBox2.Text)
                            orderby aPart.Quantity
                            select new
                            {
                                PartNumber = aPart.Number,
                                PartName = aPart.Description,
                                PartOHB = aPart.Quantity,
                                PartPrice = aPart.Price
                            };
                dataGridView1.DataSource = query.ToList();
            }
            else
            {
                textBox2.Focus();
                textBox2.BackColor = Color.DeepPink;
                textBox2.Text = "Please enter Value!";
            }
        }
    }
}
