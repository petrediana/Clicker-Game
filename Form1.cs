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
        int curr_score = 0;
        bool ok_3_score = false;
        bool ok_10_score = false;
        bool ok_50_score = false;
        bool ok_100_score = false;

        int nr_clicks_sec = 0;
        int total_clicks = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_1_point_Click(object sender, EventArgs e)
        {
            curr_score = int.Parse(score_textBox.Text);
            curr_score++;
            score_textBox.Text = curr_score.ToString();
            total_clicks++;
            show_clicks_label.Text = total_clicks.ToString();
        }

        // 10 points button
        private void button1_Click(object sender, EventArgs e)
        {
            if(ok_10_score == true)
            {
                curr_score = int.Parse(score_textBox.Text);
                curr_score += 10;
                score_textBox.Text = curr_score.ToString();
                total_clicks++;
                show_clicks_label.Text = total_clicks.ToString();
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
                total_clicks++;
                show_clicks_label.Text = total_clicks.ToString();
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
                total_clicks++;
                show_clicks_label.Text = total_clicks.ToString();
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
                total_clicks++;
                show_clicks_label.Text = total_clicks.ToString();
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
                curr_score -= 250; //getting back the points
                MessageBox.Show(string.Format("You bought a click!"));

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

        //cheat text, something happens if you enter the right cheat
        //press enter to work
        private void enter_cheat(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string cheatText = toolStripTextBox1.Text;
                if (cheatText == "Please 5000")
                {
                    curr_score = 5000;
                    toolStripTextBox1.Text = "";
                }

            }
        }

        //this timer is for creating a small text animation
        //I just want to move the text from the right side to the left side and have different texts
        private void movingText_Timer_Tick(object sender, EventArgs e)
        {          

                if (moveText_label.Left < Width)
                {
                    moveText_label.Left = moveText_label.Left + 1;
                }
                else
                {
                    moveText_label.Left = -550;
                }
            
        }

        //randomly change the flowing text
        private void changeText_timer_Tick(object sender, EventArgs e)
        {
            string[] TextsToShow = new string[5];
            TextsToShow[0] = "Click like a mad man";
            TextsToShow[1] = "Faster faster faster";
            TextsToShow[2] = "Don't stop clicking mate";
            TextsToShow[3] = "Your mouse might be on fire";
            TextsToShow[4] = "Be a proud clicker";

            Random random_text = new Random();
            int no = random_text.Next(5);

            moveText_label.Text = TextsToShow[no];
        }

        //reset user points, clicks - everything
        private void resetYourGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you REALLY sure that you want to reset everything?",
                    "RESET STATS", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                curr_score = 0;
                ok_3_score = false;
                ok_10_score = false;
                ok_50_score = false;
                ok_100_score = false;
                nr_clicks_sec = 0;
                total_clicks = 0;
                show_clicks_label.Text = "0";
                clicks_label.Text = "0 :(";
                MessageBox.Show(string.Format("Reset complete!"));
            }
            else
            {
                MessageBox.Show(string.Format("Keep on clicking then"));
            }
        }
    }
}
