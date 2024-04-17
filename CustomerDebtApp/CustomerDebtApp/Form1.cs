using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomerDebtApp
{
    public partial class Form1 : Form
    {
        private CustomerQueue newcustomer;
        public Form1()
        {
            InitializeComponent();
            newcustomer = new CustomerQueue();
        }

       

        private void Enqueue_Click(object sender, EventArgs e)
        {
            {
                int.TryParse(textBox2.Text, out int age);
                float.TryParse(textBox4.Text, out float amountOwed);

                newcustomer.Enqueue(textBox1.Text, age, textBox3.Text, amountOwed);
                textBox5.Text = newcustomer.Display();

                // Clear the textboxes used for entering customer information
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();


            }
        }

        private void Dequeue_Click(object sender, EventArgs e)
        {
            if (!newcustomer.IsEmpty())
            {
                Customer remove_customer = newcustomer.Dequeue();
                textBox6.Text = remove_customer.GetInformation();

                textBox5.Text = newcustomer.Display();
            }
            else
            {
                // MessageBox.Show("Customer Queue is empty. Cannot dequeue.");
                //MessageBox.Show("gggg");
            }
        }
    }
}
