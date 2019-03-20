using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class Form1 : Form
    {
        int curr_score = 5000;
        bool ok_3_score = false;
        bool ok_10_score = false;
        bool ok_50_score = false;
        bool ok_100_score = false;

        int nr_clicks_sec = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_point_Click(object sender, EventArgs e)
        {
            curr_score = int.Parse(score_textBox.Text);
            curr_score++;
            score_textBox.Text = curr_score.ToString();
        }

        // 10 points button
        private void button1_Click(object sender, EventArgs e)
        {
            if(ok_10_score == true)
            {
                curr_score = int.Parse(score_textBox.Text);
                curr_score += 10;
                score_textBox.Text = curr_score.ToString();
            }
            else
            {
                MessageBox.Show(string.Format("You do not have the upgrade!"));
            }
        }

        //10 point score label
        private void label5_Click(object sender, EventArgs e)
        {
            if(!ok_10_score && curr_score >= 1000)
            {
                ok_10_score = true;
                MessageBox.Show(string.Format("Upgrade purchased!"));
                curr_score -= 1000;
                score_textBox.Text = curr_score.ToString();
            }
            else
            {
                if (curr_score < 1000 && ok_10_score == false)
                    MessageBox.Show(string.Format("You do not have more than 1000 points!"));
                else
                    if (ok_10_score)
                    MessageBox.Show(string.Format("You already purchased the upgrade!"));
            }
        }

        //50 point label score
        private void label6_Click(object sender, EventArgs e)
        {
            if (!ok_50_score && curr_score >= 3000)
            {
                ok_50_score = true;
                MessageBox.Show(string.Format("Upgrade purchased!"));
                curr_score -= 3000;
                score_textBox.Text = curr_score.ToString();
            }
            else
            {
                if (curr_score < 3000 && ok_50_score == false)
                    MessageBox.Show(string.Format("You do not have more than 3000 points!"));
                else
                    if (ok_50_score)
                    MessageBox.Show(string.Format("You already purchased the upgrade!"));
            }

        }

        //50 points button
        private void button2_Click(object sender, EventArgs e)
        {
            if (ok_50_score == true)
            {
                curr_score = int.Parse(score_textBox.Text);
                curr_score += 50;
                score_textBox.Text = curr_score.ToString();
            }
            else
            {
                MessageBox.Show(string.Format("You do not have the upgrade!"));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //3 points button
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ok_3_score == true)
            {
                curr_score = int.Parse(score_textBox.Text);
                curr_score += 3;
                score_textBox.Text = curr_score.ToString();
            }
            else
            {
                MessageBox.Show(string.Format("You do not have the upgrade!"));
            }
        }

        //3 points label
        private void label8_Click(object sender, EventArgs e)
        {
            if (!ok_3_score && curr_score >= 500)
            {
                ok_3_score = true;
                MessageBox.Show(string.Format("Upgrade purchased!"));
                curr_score -= 500;
                score_textBox.Text = curr_score.ToString();
            }
            else
            {
                if (curr_score < 500 && ok_3_score == false)
                    MessageBox.Show(string.Format("You do not have more than 500 points!"));
                else
                    if (ok_3_score)
                    MessageBox.Show(string.Format("You already purchased the upgrade!"));
            }
        }

        //100 points button
        private void button3_Click(object sender, EventArgs e)
        {
            if (ok_100_score == true)
            {
                curr_score = int.Parse(score_textBox.Text);
                curr_score += 100;
                score_textBox.Text = curr_score.ToString();
            }
            else
            {
                MessageBox.Show(string.Format("You do not have the upgrade!"));
            }
        }

        //100 points label
        private void label7_Click(object sender, EventArgs e)
        {
            if (!ok_100_score && curr_score >= 8000)
            {
                ok_100_score = true;
                MessageBox.Show(string.Format("Upgrade purchased!"));
                curr_score -= 8000;
                score_textBox.Text = curr_score.ToString();
            }
            else
            {
                if (curr_score < 8000 && ok_100_score == false)
                    MessageBox.Show(string.Format("You do not have more than 8000 points!"));
                else
                    if (ok_100_score)
                    MessageBox.Show(string.Format("You already purchased the upgrade!"));
            }
        }

        //button for adding more clicks per sec
        private void button4_Click(object sender, EventArgs e)
        {
            if(curr_score >= 250)
            {
                nr_clicks_sec++;
                clicks_label.Text = nr_clicks_sec.ToString() + " :)";
                MessageBox.Show(string.Format("You bought a click!"));

                curr_score -= 250; //getting back the points

            }
            else
            {
                MessageBox.Show(string.Format("You do not have more than 250 points!"));
            }
        }

        //timer Tick method for clicks per sec
        private void timer1_Tick(object sender, EventArgs e)
        {
            curr_score += nr_clicks_sec;
            score_textBox.Text = curr_score.ToString();
        }
    }
}
