using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked ^ checkBox2.Checked) == false)
            {
                MessageBox.Show("Choose only 5 x 5 or 3 x 3!");
                return;
            }
            if (checkBox1.Checked)
            {
                Game newGame = new Game(false, textBox1.Text);
                Visible = false;
                if (!newGame.IsDisposed)
                    newGame.ShowDialog();
                Visible = true;
            }
            else
            {
                Game2 newGame2 = new Game2(false, textBox1.Text);
                Visible = false;
                if (!newGame2.IsDisposed)
                    newGame2.ShowDialog();
                Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked ^ checkBox2.Checked) == false)
            {
                MessageBox.Show("Choose only 5 x 5 or 3 x 3!");
                return;
            }
            if (checkBox1.Checked)
            {
                Game newGame = new Game(true);
                Visible = false;
                if (!newGame.IsDisposed)
                    newGame.ShowDialog();
                Visible = true;
            }
            else
            {
                Game2 newGame = new Game2(true);
                Visible = false;
                if (!newGame.IsDisposed)
                    newGame.ShowDialog();
                Visible = true;
            }
        }
    }
}