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
            this.pointList = new System.Windows.Forms.ListBox();
            this.forceList = new System.Windows.Forms.ListBox();
            this.addPointButton = new System.Windows.Forms.Button();
            this.removePointButton = new System.Windows.Forms.Button();
            this.addForceButton = new System.Windows.Forms.Button();
            this.removeForceButton = new System.Windows.Forms.Button();
            this.updateForceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            // 
            // forceList
            // 
            this.forceList.FormattingEnabled = true;
            this.forceList.ItemHeight = 20;
            this.forceList.Location = new System.Drawing.Point(81, 52);
            this.forceList.Name = "forceList";
            this.forceList.Size = new System.Drawing.Size(101, 284);
            this.forceList.TabIndex = 1;
            // 
            // addPointButton
            // 
            this.addPointButton.Location = new System.Drawing.Point(81, 12);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(101, 30);
            this.addPointButton.TabIndex = 2;
            this.addPointButton.Text = "addPoint";
            this.addPointButton.UseVisualStyleBackColor = true;
            // 
            // removePointButton
            // 
            this.removePointButton.Location = new System.Drawing.Point(188, 12);
            this.removePointButton.Name = "removePointButton";
            this.removePointButton.Size = new System.Drawing.Size(133, 30);
            this.removePointButton.TabIndex = 3;
            this.removePointButton.Text = "removePoint";
            this.removePointButton.UseVisualStyleBackColor = true;
            // 
            // addForceButton
            // 
            this.addForceButton.Location = new System.Drawing.Point(188, 48);
            this.addForceButton.Name = "addForceButton";
            this.addForceButton.Size = new System.Drawing.Size(133, 30);
            this.addForceButton.TabIndex = 4;
            this.addForceButton.Text = "addForce";
            this.addForceButton.UseVisualStyleBackColor = true;
            // 
            // removeForceButton
            // 
            this.removeForceButton.Location = new System.Drawing.Point(326, 48);
            this.removeForceButton.Name = "removeForceButton";
            this.removeForceButton.Size = new System.Drawing.Size(132, 30);
            this.removeForceButton.TabIndex = 5;
            this.removeForceButton.Text = "removeForce";
            this.removeForceButton.UseVisualStyleBackColor = true;
            // 
            // updateForceButton
            // 
            this.updateForceButton.Location = new System.Drawing.Point(12, 90);
            this.updateForceButton.Name = "updateForceButton";
            this.updateForceButton.Size = new System.Drawing.Size(252, 30);
            this.updateForceButton.TabIndex = 6;
            this.updateForceButton.Text = "updateForce";
            this.updateForceButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.angleBox);
            this.groupBox1.Controls.Add(this.updateForceButton);
            this.groupBox1.Controls.Add(this.valueBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 248);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "force";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "angle";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(59, 26);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(205, 26);
            this.valueBox.TabIndex = 2;
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(59, 58);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(205, 26);
            this.angleBox.TabIndex = 3;
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 355);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}