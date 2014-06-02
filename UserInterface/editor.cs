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
    public partial class editor : Form
    {
        Startup SForm;
        public editor()
        {
            InitializeComponent();
        }

        public editor(Startup sf)
        {
            SForm = sf;
            InitializeComponent();
        }

        private void editor_Closing(object sender, FormClosingEventArgs e)
        {
            SForm.editButton_Enable();
        }

        private void editor_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= SForm.map.Points.Count - 1; i++)
            {
                this.pointList.Items.Add(i);
            }
        }

        private void pointList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.forceList.Items.Clear();
            if (this.pointList.SelectedIndex >= 0)
            {
                for (int i = 0; i <= SForm.map.Points[this.pointList.SelectedIndex].Forces.Count - 1; i++)
                {
                    this.forceList.Items.Add(i);
                }
                this.removePointButton.Enabled = true;
            }
            else
            {
                this.removePointButton.Enabled = false;
            }
        }

        private void forceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.forceList.SelectedIndex >= 0)
            {
                this.removeForceButton.Enabled = true;
            }
            else
            {
                this.removeForceButton.Enabled = false;
            }
        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            this.pointList.Items.Add(SForm.map.Points.Count);
            SForm.map.Points.Add(new Classes.Point());
        }

        private void removePointButton_Click(object sender, EventArgs e)
        {
            SForm.map.Points.RemoveAt(this.pointList.SelectedIndex);
            this.pointList.Items.RemoveAt(this.pointList.SelectedIndex);
        }

        private void updatePointButton_Click(object sender, EventArgs e)
        {
            SForm.map.Points[this.pointList.SelectedIndex].X = Convert.ToDouble(this.xBox.Text);
            SForm.map.Points[this.pointList.SelectedIndex].Y = Convert.ToDouble(this.yBox.Text);
            SForm.map.Points[this.pointList.SelectedIndex].Speed = new Speed(
                Convert.ToDouble(this.speedValueBox.Text), Convert.ToDouble(this.speedAngleBox.Text));
            SForm.map.Points[this.pointList.SelectedIndex].m = Convert.ToDouble(this.mBox.Text);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.pauseButton.Enabled = true;
            this.startButton.Enabled = false;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.pauseButton.Enabled = false;
            this.startButton.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.pointList.SelectedIndex >= 0)
            {
                this.xBox.Text = Convert.ToString(SForm.map.Points[this.pointList.SelectedIndex].X);
                this.yBox.Text = Convert.ToString(SForm.map.Points[this.pointList.SelectedIndex].Y);
                this.asBox.Text = Convert.ToString(SForm.map.Points[this.pointList.SelectedIndex].a.Value);
                this.speedAngleBox.Text = Convert.ToString(SForm.map.Points[this.pointList.SelectedIndex].Speed.Angle);
                this.speedValueBox.Text = Convert.ToString(SForm.map.Points[this.pointList.SelectedIndex].Speed.Value);
                if (this.forceList.SelectedIndex >= 0)
                {
                    this.valueBox.Text = Convert.ToString(SForm.map.Points[this.pointList.SelectedIndex].Forces[this.forceList.SelectedIndex].Value);
                    this.angleBox.Text = Convert.ToString(SForm.map.Points[this.pointList.SelectedIndex].Forces[this.forceList.SelectedIndex].Angle);
                }
            }
        }

        private void addForceButton_Click(object sender, EventArgs e)
        {
            this.forceList.Items.Add(SForm.map.Points[this.pointList.SelectedIndex].Forces.Count);
            SForm.map.Points[this.pointList.SelectedIndex].Forces.Add(new Force(0, 0));
        }

        private void removeForceButton_Click(object sender, EventArgs e)
        {
            SForm.map.Points[this.pointList.SelectedIndex].Forces.RemoveAt(this.forceList.SelectedIndex);
            this.forceList.Items.RemoveAt(this.forceList.SelectedIndex);
        }

        private void updateForceButton_Click(object sender, EventArgs e)
        {
            SForm.map.Points[this.pointList.SelectedIndex].Forces[this.forceList.SelectedIndex].Value = Convert.ToDouble(valueBox.Text);
            SForm.map.Points[this.pointList.SelectedIndex].Forces[this.forceList.SelectedIndex].Angle = Convert.ToDouble(angleBox.Text);
        }
    }
}
