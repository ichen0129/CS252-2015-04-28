using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numberTextBox.Text);
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            MessageBox.Show(string.Format("Total ={0}", sum));
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != '\b')
            {
                MessageBox.Show("Please input a number.");
                e.Handled = true;
            }
        }
    }
}