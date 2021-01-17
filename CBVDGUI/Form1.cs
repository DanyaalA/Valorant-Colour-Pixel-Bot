using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBVDGUI
{
    public partial class Form2 : Form
    {
        bool started = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void xuiCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void xuiBanner1_Click(object sender, EventArgs e)
        {

        }

        private void MainSegment_TabIndexChanged(object sender, EventArgs e)
        {
            MainSegment.Text = "xx";
        }

        private void MainSegment_Click(object sender, EventArgs e)
        {
            if (MainSegment.SelectedIndex == 0)
            {
                GeneralPanel.BringToFront();
                GeneralPanel.Visible = true;
                AimPanel.Visible = false;
            }
            else if (MainSegment.SelectedIndex == 1)
            {
                AimPanel.BringToFront();
                AimPanel.Visible = true;
                GeneralPanel.Visible = false;
            }
            
                  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 376;
            Height = 385;

            AimPanel.Location = GeneralPanel.Location;
            

            GeneralPanel.BringToFront();
            GeneralPanel.Visible = true;
            AimPanel.Visible = false;
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            //Console.Write("Bot Status: " + Bot.Enabled);

            if (started)
            {
                //Console.WriteLine(SuperButton.SuperSelected);
                SuperButton.ButtonText = "Stop";
                SuperButton.SuperSelected = true;
               // Bot.Enabled = true;
            }
            else
            {
                SuperButton.ButtonText = "Start";
                SuperButton.SuperSelected = false;
                //Bot.Enabled = false;
            }

            
        }

        private void xuiCheckBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
