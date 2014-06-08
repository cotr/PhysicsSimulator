namespace Cotr.Physics.Simulator.UI
{
    partial class editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pointList = new System.Windows.Forms.ListBox();
            this.forceList = new System.Windows.Forms.ListBox();
            this.addPointButton = new System.Windows.Forms.Button();
            this.removePointButton = new System.Windows.Forms.Button();
            this.addForceButton = new System.Windows.Forms.Button();
            this.removeForceButton = new System.Windows.Forms.Button();
            this.updateForceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.speedAngleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.speedValueBox = new System.Windows.Forms.TextBox();
            this.updatePointButton = new System.Windows.Forms.Button();
            this.yBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.asBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointList
            // 
            this.pointList.FormattingEnabled = true;
            this.pointList.ItemHeight = 20;
            this.pointList.Location = new System.Drawing.Point(12, 12);
            this.pointList.Name = "pointList";
            this.pointList.Size = new System.Drawing.Size(62, 324);
            this.pointList.TabIndex = 0;
            this.pointList.SelectedIndexChanged += new System.EventHandler(this.pointList_SelectedIndexChanged);
            // 
            // forceList
            // 
            this.forceList.FormattingEnabled = true;
            this.forceList.ItemHeight = 20;
            this.forceList.Location = new System.Drawing.Point(468, 52);
            this.forceList.Name = "forceList";
            this.forceList.Size = new System.Drawing.Size(101, 284);
            this.forceList.TabIndex = 1;
            this.forceList.SelectedIndexChanged += new System.EventHandler(this.forceList_SelectedIndexChanged);
            // 
            // addPointButton
            // 
            this.addPointButton.Location = new System.Drawing.Point(81, 12);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(101, 30);
            this.addPointButton.TabIndex = 2;
            this.addPointButton.Text = "addPoint";
            this.addPointButton.UseVisualStyleBackColor = true;
            this.addPointButton.Click += new System.EventHandler(this.addPointButton_Click);
            // 
            // removePointButton
            // 
            this.removePointButton.Enabled = false;
            this.removePointButton.Location = new System.Drawing.Point(188, 12);
            this.removePointButton.Name = "removePointButton";
            this.removePointButton.Size = new System.Drawing.Size(133, 30);
            this.removePointButton.TabIndex = 3;
            this.removePointButton.Text = "removePoint";
            this.removePointButton.UseVisualStyleBackColor = true;
            this.removePointButton.Click += new System.EventHandler(this.removePointButton_Click);
            // 
            // addForceButton
            // 
            this.addForceButton.Location = new System.Drawing.Point(575, 52);
            this.addForceButton.Name = "addForceButton";
            this.addForceButton.Size = new System.Drawing.Size(133, 30);
            this.addForceButton.TabIndex = 4;
            this.addForceButton.Text = "addForce";
            this.addForceButton.UseVisualStyleBackColor = true;
            this.addForceButton.Click += new System.EventHandler(this.addForceButton_Click);
            // 
            // removeForceButton
            // 
            this.removeForceButton.Location = new System.Drawing.Point(714, 52);
            this.removeForceButton.Name = "removeForceButton";
            this.removeForceButton.Size = new System.Drawing.Size(132, 30);
            this.removeForceButton.TabIndex = 5;
            this.removeForceButton.Text = "removeForce";
            this.removeForceButton.UseVisualStyleBackColor = true;
            this.removeForceButton.Click += new System.EventHandler(this.removeForceButton_Click);
            // 
            // updateForceButton
            // 
            this.updateForceButton.Location = new System.Drawing.Point(12, 210);
            this.updateForceButton.Name = "updateForceButton";
            this.updateForceButton.Size = new System.Drawing.Size(253, 30);
            this.updateForceButton.TabIndex = 6;
            this.updateForceButton.Text = "updateForce";
            this.updateForceButton.UseVisualStyleBackColor = true;
            this.updateForceButton.Click += new System.EventHandler(this.updateForceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.angleBox);
            this.groupBox1.Controls.Add(this.updateForceButton);
            this.groupBox1.Controls.Add(this.valueBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(575, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 253);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "force";
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(59, 58);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(206, 26);
            this.angleBox.TabIndex = 3;
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(59, 26);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(206, 26);
            this.valueBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "value";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.updatePointButton);
            this.groupBox2.Controls.Add(this.yBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.xBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.asBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(81, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 293);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "point";
            // 
            // mBox
            // 
            this.mBox.Location = new System.Drawing.Point(63, 25);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(306, 26);
            this.mBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "m";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.speedAngleBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.speedValueBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 91);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "speed";
            // 
            // speedAngleBox
            // 
            this.speedAngleBox.Location = new System.Drawing.Point(57, 51);
            this.speedAngleBox.Name = "speedAngleBox";
            this.speedAngleBox.Size = new System.Drawing.Size(306, 26);
            this.speedAngleBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "angle";
            // 
            // speedValueBox
            // 
            this.speedValueBox.Location = new System.Drawing.Point(57, 19);
            this.speedValueBox.Name = "speedValueBox";
            this.speedValueBox.Size = new System.Drawing.Size(306, 26);
            this.speedValueBox.TabIndex = 1;
            // 
            // updatePointButton
            // 
            this.updatePointButton.Location = new System.Drawing.Point(6, 250);
            this.updatePointButton.Name = "updatePointButton";
            this.updatePointButton.Size = new System.Drawing.Size(369, 30);
            this.updatePointButton.TabIndex = 7;
            this.updatePointButton.Text = "updatePoint";
            this.updatePointButton.UseVisualStyleBackColor = true;
            this.updatePointButton.Click += new System.EventHandler(this.updatePointButton_Click);
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(63, 218);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(306, 26);
            this.yBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "y";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(63, 186);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(306, 26);
            this.xBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "x";
            // 
            // asBox
            // 
            this.asBox.Location = new System.Drawing.Point(63, 154);
            this.asBox.Name = "asBox";
            this.asBox.ReadOnly = true;
            this.asBox.Size = new System.Drawing.Size(306, 26);
            this.asBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "a";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(327, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 30);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "startWatch";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(434, 12);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(101, 30);
            this.pauseButton.TabIndex = 10;
            this.pauseButton.Text = "pauseWatch";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 353);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.removeForceButton);
            this.Controls.Add(this.addForceButton);
            this.Controls.Add(this.removePointButton);
            this.Controls.Add(this.addPointButton);
            this.Controls.Add(this.forceList);
            this.Controls.Add(this.pointList);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "editor";
            this.Text = "editor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.editor_Closing);
            this.Load += new System.EventHandler(this.editor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pointList;
        private System.Windows.Forms.ListBox forceList;
        private System.Windows.Forms.Button addPointButton;
        private System.Windows.Forms.Button removePointButton;
        private System.Windows.Forms.Button addForceButton;
        private System.Windows.Forms.Button removeForceButton;
        private System.Windows.Forms.Button updateForceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updatePointButton;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox asBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox speedValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox speedAngleBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox mBox;
        private System.Windows.Forms.Label label8;
    }
}