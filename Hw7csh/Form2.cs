using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw7csh
{
    public partial class Form2 : Form
    {
        private int EnterNumber;
        private int ComputerNumber;
        private Random random = new Random();
        
        public Form2()
        {
            InitializeComponent();
            ComputerNumber = random.Next(100);
            
        }
        private void checkwin()
        {
            if (EnterNumber == ComputerNumber)
            {
                MessageBox.Show("Congratulations you win!!", "Guess the number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Do you want play again?" , "Guess the number", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    EnterNumber = 0;
                    ComputerNumber = random.Next(100);
                   
                }
                else { Close(); }

            }
            if (EnterNumber < ComputerNumber) labelInfo.Text = "Desired number hihgt";
            if (EnterNumber > ComputerNumber) labelInfo.Text = "Desired number low";
        }

        

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            EnterNumber = int.Parse(textBox1.Text);
            checkwin();
        }
    }
}
