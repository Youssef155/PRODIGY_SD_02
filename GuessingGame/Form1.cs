using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {

        Random RandomNumber = new Random();
        int num = 0;
        int NumOfguesses = 0;

        public Form1()
        {
            InitializeComponent();
            load_Text();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int GuessedNum = Convert.ToInt32(txtNumber.Text);
            NumOfguesses ++;
            numOfGuessesTxt.Text = $"you guessed {NumOfguesses} time(s).";

            if (num == GuessedNum)
            {
                MessageBox.Show("Nice Job!, you guessed it right");
                load_Text();
                txtNumber.Text = "";
                NumOfguesses = 0;
            }
            else if(GuessedNum > num)
            {
                MessageBox.Show("Too High!");
            }
            else
            {
                MessageBox.Show("Too Low!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void load_Text()
        {
            num = RandomNumber.Next(0, 11);
            label1.Text = "Guess a number between 0 and 10";
            numOfGuessesTxt.Text = "you guessed 0 time(s).";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
