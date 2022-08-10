using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public partial class Form1 : Form
    {
        bool turn = true;// true = X turn; false = Y turn
        int turn_count = 0;
        static string player1, player2;


        public Form1()
        {
            InitializeComponent();
        }

        public static void setPlayernames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Kyle", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizantal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text && B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text && C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text && B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text && B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            else if ((A1.Text == B2.Text && B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text && B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();

                string winner = "";

                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Wins!", "Yay!");
            }//end if
            else
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Bummer!");
                }
            }

        }//end checkForWinner

        private void disableButtons()
        {
           
                foreach (Control c in Controls)

                {
                try
                {

                    Button b = (Button)c;
                    b.Enabled = false;


                }//end try
                catch { }
            }//end foreach
           

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            
                foreach (Control c in Controls)
                {
                    try
                    {

                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";

               
                    }//end try
                    catch { }
                }//end foreach
            
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)

                    b.Text = "X";
                else
                    b.Text = "O";
            }//end if
            
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color blue = Color.LightBlue;
            base.BackColor = blue;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color white = Color.White;
            base.BackColor = white;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color red = Color.LightPink;
            base.BackColor = red;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color yellow = Color.LightYellow;
            base.BackColor = yellow;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color green = Color.LightGreen;
            base.BackColor = green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
        }

    }
}
