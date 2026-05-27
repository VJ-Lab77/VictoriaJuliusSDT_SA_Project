using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Stock_Capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Record Added");
            Console.Write("Mobile Code: " + txtCode.Text);
            Console.WriteLine("Make: " + txtMake.Text);
            Console.WriteLine("Quantity: " + txtQuantity.Text);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Record Deleted");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Record Found");
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
