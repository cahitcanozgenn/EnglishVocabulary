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
    public partial class QuickGame3Player : Form
    {
        public QuickGame3Player()
        {
            InitializeComponent();
        }
        public int timer { get; set; }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            label1.Text = sayac.ToString();
            if (sayac == timer)
            {
                timer1.Stop();
            }
        }

        private void QuickGame3Player_Load(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
