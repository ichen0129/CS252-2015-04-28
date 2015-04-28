using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int month = int.Parse(monthTextBox.Text);

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    MessageBox.Show("Winter");
                    break;

                case 3:
                case 4:
                case 5:
                    MessageBox.Show("Spring");
                    break;

                case 6:
                case 7:
                case 8:
                    MessageBox.Show("Summer");
                    break;

                case 9:
                case 10:
                case 11:
                    MessageBox.Show("Fall");
                    break;

                default:
                    MessageBox.Show("error");
                    break;
            }
        }

        private void monthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != '\b')
            {
                MessageBox.Show("Please input a number.");
                e.Handled = true;
            }
        }
    }
}