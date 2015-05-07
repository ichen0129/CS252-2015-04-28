using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private int[] guess = new int[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            GetGuessNumber();
            resultTextBox.Text = "Start\r\n";
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int countA = 0, countB = 0;
            int[] readbuffer = new int[4];

            if (ansTextBox.Text.Length < 4 || ansTextBox.Text.Length > 4)
            {
                MessageBox.Show("Please enter a 4 digit number");
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                readbuffer[i] = int.Parse(ansTextBox.Text.Substring(i, 1));
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (guess[i] == readbuffer[j])
                    {
                        if (i == j)
                            countA++;
                        else
                            countB++;
                    }
                }
            }
            if (countA == 4)
                resultTextBox.Text += "Right number !";
            else
                resultTextBox.Text += "Wrong... " + ansTextBox.Text + " " + countA + "A" + countB + "B" + "\r\n";

            ansTextBox.Text = "";
        }

        private void ansTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != '\b')
            {
                MessageBox.Show("Please input a number.");
                e.Handled = true;
            }
        }

        private void GetGuessNumber()
        {
            int number;

            Random random = new Random();
            number = 0;
            while (number < 4)
            {
                guess[number] = random.Next(0, 10);
                for (int i = 0; i < number; i++)
                {
                    if (guess[number] == guess[i])
                        number--;
                }
                number++;
            }
        }
    }
}