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
    public partial class Form3 : Form
    {
        internal static bool visible;

        public BorderStyle BorderStyle { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private static void setP1Avatar(object text)
        {
            throw new NotImplementedException();
        }
    }
}
