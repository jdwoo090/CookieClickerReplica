using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClickerProject
{
    public partial class Form1 : Form
    {
        public Boolean up1;
        public Boolean up2;
        public Boolean up3;
        public Boolean up4;
        public Boolean up5;
        public Boolean up6;
        public Boolean up7;
        public Boolean nerd;
        public Boolean prgrm;
        public Boolean hckmn;
        int score;
        int score2;
        int score3;

        CCClass C = new CCClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (up1 == true) { C.click(); }
            if (up2 == true) { score2 = score2 + 5; }
            if (up3 == true) { score3 = score3 + 10; }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            score = C.amount(C.getScore());
            //label1.Text = C.ToString();
            if (label2.Text == "Per Click: 1") {
                button1.Text = "Upgrade: 20 cookies";
                label1.Text = "Cookies: " + score;
                up1 = true;
                up2 = false;
                up3 = false;
            }
            if (label2.Text == "Per Click: 5")
            {
                button1.Text = "Upgrade: MAX";
                label1.Text = "Cookies: " + score2;
                up2 = true;
                up1 = false;
                up3 = false;
            }
            /*if (label2.Text == "Per Click: 10")
            {
                button1.Text = "Upgrade: MAX";
                label1.Text = "Cookies: " + score3;
                up3 = true;
                up2 = false;
                up1 = false;
            }*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(up1 == true) {
                if (score >= 20)
                {
                    C.upgrade();
                    label2.Text = "Per Click: 5";
                    score2 = C.amount(score) - 20;
                }
                if (up2 == true)
                {
                    if (score >= 30)
                    {
                        C.upgrade();
                        label2.Text = "Per Click: 10";
                        score3 = C.amount(score2) - 30;
                    }
                }
            }
        }
    }
}
