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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                QuickGame2Player qg2p = new QuickGame2Player();
                qg2p.timer = Convert.ToInt32(comboBox1.Text);
                qg2p.Show();
                this.Hide();
            }
            else if(radioButton2.Checked)
            {
                QuickGame3Player qg3p = new QuickGame3Player();
                qg3p.timer = Convert.ToInt32(comboBox1.Text);
                qg3p.Show();
                this.Hide();
            }
            else if(radioButton3.Checked)
            {
                QuickGame4Player qg4p = new QuickGame4Player();
                qg4p.timer = Convert.ToInt32(comboBox1.Text);
                qg4p.Show();
                this.Hide();
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton6.Checked)
            {
                Challenge2PlayerForm c2pf = new Challenge2PlayerForm();
                Challenge2Player c2p = new Challenge2Player();
                c2p.timer = Convert.ToInt32(comboBox2.Text);
                c2pf.Show();
                this.Hide();
            }
            else if(radioButton5.Checked)
            {
                Challenge3PlayerForm c3pf = new Challenge3PlayerForm();
                Challenge3Player c3p = new Challenge3Player();
                c3p.timer = Convert.ToInt32(comboBox2.Text);
                c3pf.Show();
                this.Hide();
            }
            else if(radioButton4.Checked)
            {
                Challenge4PlayerForm c4pf = new Challenge4PlayerForm();
                Challenge4Player c4p = new Challenge4Player();
                c4p.timer = Convert.ToInt32(comboBox2.Text);
                c4pf.Show();
                this.Hide();
            }
        }
    }
}
