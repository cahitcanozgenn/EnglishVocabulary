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
    public partial class QuickGame2Player : Form
    {
        public QuickGame2Player()
        {
            InitializeComponent();
        }
        public int timer { get; set; }
        int sayac = 0;
        private void QuickGame2Player_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayac++;

            label1.Text = sayac.ToString();
            if (sayac == timer)
            {
                timer1.Stop();
            }
        }
    }
}
