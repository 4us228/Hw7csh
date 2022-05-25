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
    public partial class Form1 : Form
    {
        private int userNumber;
        private int computerNumber;
        private Random random = new Random();
        private int count;

        public Form1()
        {
            InitializeComponent();
            UpdateGameState(userNumber,random.Next(99));
        }

        private void UpdateGameState(int userNumber)
        {
            labelUserNumber.Text = $"Your Number:{userNumber}";
            labelCountOfTry.Text = $"Number of try: {count}";
        }
        private void UpdateGameState(int userNumber, int computerNumber)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Find number:{computerNumber}";
            labelCountOfTry.Text = $"Number of try: {count}";
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            count = 0;
            UpdateGameState(userNumber, random.Next(99));  
            
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {   
            count++;
            UpdateGameState(userNumber *= 2);
            CheckWin();


        }

        private void buttonPLusOne_Click(object sender, EventArgs e)
        { 
            count++;
            UpdateGameState(++userNumber);
            CheckWin();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Find Number:{computerNumber}", "Doubler Game",MessageBoxButtons.OK);
            labelMenuTitle.Visible = false;
            buttonStart.Visible = false;
            buttonExit.Visible = false;
            labelComputerNumber.Visible = true;
            labelUserNumber.Visible = true;
            labelCountOfTry.Visible = true;
            buttonReset.Visible = true;
            buttonPlusOne.Visible = true;
            buttonMultiply.Visible = true;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CheckWin()
        {
            if(userNumber == computerNumber)
            {
                MessageBox.Show("You win congratulations!!", "Doubler game",MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Do you want play again", "Doubler game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    count = 0;
                    UpdateGameState(userNumber, random.Next(99));
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
