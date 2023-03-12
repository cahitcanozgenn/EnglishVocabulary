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
    public partial class Challenge4Player : Form
    {
        public Challenge4Player()
        {
            InitializeComponent();
        }
        public int timer { get; set; }
        int sayac = 0;
        public string player1 { get; set; }
        public string player2 { get; set; }
        public string player3 { get; set; }
        public string player4 { get; set; }
        private void Challenge4Player_Load(object sender, EventArgs e)
        {
            label1.Text = player1;
            label2.Text = player2;
            label3.Text = player3;
            label4.Text = player4;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            label5.Text = sayac.ToString();
            if (sayac == timer)
            {
                timer1.Stop();
            }
        }
    }
}
