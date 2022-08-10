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
    public partial class Form2 : Form
    {
        private static bool visible;
        static string avatar1, avatar2;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setPlayernames(p1.Text, p2.Text);
            this.Close();
        }

        private void p2_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
