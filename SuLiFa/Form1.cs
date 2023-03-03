using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SuLiFa
{
    public partial class Form1 : Form
    {
        string playerChoise;
        string computerChoise;
        string[] options = { "К", "Б", "Н", "Б", "Н", "К" };
        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_камень_Click(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            playerChoise = (string)tempButton.Tag;
            int i = random.Next(0, options.Length);
            computerChoise = options[i];
            label2.Text = "Siz:" + UpdateTextandImage(playerChoise, Player_Box);
            label1.Text = "Kampyuter:" + UpdateTextandImage(computerChoise, Comp_Box);
            CheckGame();
        }
        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = null;
            switch (text)
            {
                case "К":
                    word = "Tas";
                    pic.Image = Properties.Resources.Камень;
                    break;
                case "Б":
                    word = "Qag'az";
                    pic.Image = Properties.Resources.Бумага;
                    break;
                case "Н":
                    word = "Qayshi";
                    pic.Image = Properties.Resources.Ножницы;
                    break;
            }
            return word;
        }
        private void CheckGame()
        {
            if (computerChoise == playerChoise)
            {
                draw = "Ten'!";
            }
            else if (playerChoise == "К" && computerChoise == "Б" || playerChoise == "Н" && computerChoise == "К" || playerChoise == "Б" && computerChoise == "Н")
            {
                computerScore++;
                draw = null;
            }
            else
            {
                playerScore++;
                draw = null;
            }
            label4.Text = "Kampyuter:" + computerScore + Environment.NewLine + draw;
            label3.Text = "Siz:" + playerScore + Environment.NewLine + draw;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Comp_Box_Click(object sender, EventArgs e)
        {

        }
    }
}