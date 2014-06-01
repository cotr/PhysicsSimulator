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
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            new view(this).Show();
        }
    }
}
