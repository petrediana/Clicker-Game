using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class MainMenu : Form
    {
        bool helpRead = false;
        bool userCreated = false;
        bool firstTime = false;
        

        //a list for having more users, for saving progress
        List<string> users_list = new List<string>();

        public MainMenu()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            helpRead = true;
            firstTime = true;
            MessageBox.Show("Welcome to my tiny clicker game.\nThe rules are very simple, " +
                "just click on the buttons to gain points. Different buttons give you different points.\n" +
                "In order to get acces to higher click scores you will first need to purchase the upgrade." +
                " Purchasing an upgrade is simple! Just click on the 'Purchase?' text" +
                " that you see on the left side." +
                "\nYou can also unlock auto-generated points. Basically you get clicks without" +
                " actually clicking. Sounds cool, right? You get those by matching your" +
                " mouse pointer with the '++' button\n" +
                "Create your user and after that you are ready to go on a clicking journey...\n" +
                " Don't forget to click and have fun exploring my game :)", "HEEELP", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!userCreated && !helpRead)
                MessageBox.Show("Read the how to tutorial first");
            else
            {
                if (!userCreated)
                    MessageBox.Show("Create the user first! I know, you must be impatient to click");
                else
                {
                    if (!helpRead && !firstTime)
                        MessageBox.Show("See the how to!! Or if you are that impatient close it fast");
                    else
                    {
                        Hide();
                        Form1 gameform = new Form1();
                        gameform.ShowDialog();
                        Close();
                    }
                }
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String user;
            user = filename_TextBox.Text;
            foreach(var us in users_list)
            {
                if (user == us)
                {
                    MessageBox.Show("Logged as: {0}", user);
                    filename_TextBox.Text = "";
                }
            }

            if (user.Length < 3)
            {
                MessageBox.Show("Your user needs to be at least 3 characters long!");
                filename_TextBox.Text = "";
            }
            else
            {
                userCreated = true;
                MessageBox.Show(string.Format("Your user goes by the name: {0}", user));
                showUser_Label.Text = user;
                filename_TextBox.Text = "";
                filename_TextBox.Enabled = false;
                button3.Enabled = false;
                users_list.Add(user);
            }
        }
    }
}
