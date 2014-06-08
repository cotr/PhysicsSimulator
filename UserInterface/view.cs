using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cotr.Physics.Simulator.Classes;

namespace Cotr.Physics.Simulator.UI
{
    public partial class view : Form
    {
        Startup SForm;
        Graphics graForm;
        public view()
        {
            InitializeComponent();
        }
        public view(Startup sf)
        {
            SForm = sf;
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            
        }

        private void view_Closing(object sender, FormClosingEventArgs e)
        {
            SForm.viewButton_Enable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graForm = this.CreateGraphics();
            graForm.Clear(SystemColors.Control);
            foreach (Classes.Point p in SForm.map.Points)
            {
                int x = (int)Math.Floor(p.X);
                int y = (int)Math.Floor(p.Y);
                if ((x <= this.Size.Width - 1) && (y <= this.Size.Height - 1))
                {
                    graForm.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(new System.Drawing.Point(x, y), new Size(2, 2)));
                }
            }
        }
    }
}
