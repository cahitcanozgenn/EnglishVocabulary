using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishVocabulary
{
    public partial class Challenge4PlayerForm : Form
    {
        public Challenge4PlayerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Challenge4Player c4p = new Challenge4Player();
            c4p.player1 = textBox1.Text;
            c4p.player2 = textBox2.Text;
            c4p.player3 = textBox3.Text;
            c4p.player4 = textBox4.Text;
            c4p.Show();
            this.Hide();
        }
    }
}
