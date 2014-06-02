using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Cotr.Physics.Simulator.Classes;
using System.Diagnostics;

namespace Cotr.Physics.Simulator.UI
{
    public partial class Startup : Form
    {
        public Map map { get; set; }
        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            this.label1.Text += "\nUser Interface build version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.label1.Text += "\nClass Library build version: " +
                Assembly.GetAssembly(typeof(Force)).GetName().Version.ToString();
#if DEBUG
            this.label1.Text += "\nBuild branch: DEBUG";
#else
            this.label1.Text += "\nBuild branch: RELEASE";
#endif
            map = new Map();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            new view(this).Show();
            this.viewButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pauseButton.Enabled = true;
            startButton.Enabled = false;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            startButton.Enabled = true;
            pauseButton.Enabled = false;
        }

        internal void viewButton_Enable()
        {
            this.viewButton.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            new editor(this).Show();
            this.editButton.Enabled = false;
        }

        internal void editButton_Enable()
        {
            this.editButton.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
#if DEBUG
            Debug.WriteLine("<Startup>(timer1)Timer Ticked.");
#endif
            map.Tick();
        }
    }
}
