namespace Easings
{
    partial class Form1
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
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.button_1to2 = new System.Windows.Forms.Button();
            this.button_2to1 = new System.Windows.Forms.Button();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_y1 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.textBox_y2 = new System.Windows.Forms.TextBox();
            this.textBox_w1 = new System.Windows.Forms.TextBox();
            this.textBox_h1 = new System.Windows.Forms.TextBox();
            this.textBox_w2 = new System.Windows.Forms.TextBox();
            this.textBox_h2 = new System.Windows.Forms.TextBox();
            this.label_x1 = new System.Windows.Forms.Label();
            this.label_y1 = new System.Windows.Forms.Label();
            this.label_x2 = new System.Windows.Forms.Label();
            this.label_y2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_SetLoc1 = new System.Windows.Forms.Button();
            this.button_SetLoc2 = new System.Windows.Forms.Button();
            this.button_SetSize1 = new System.Windows.Forms.Button();
            this.button_SetSize2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(87, 12);
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(100, 20);
            this.textBox_Duration.TabIndex = 0;
            this.textBox_Duration.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duration (ms)";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Linear",
            "Sine In",
            "Sine Out",
            "Sine InOut",
            "Quadratic In",
            "Quadratic Out",
            "Quadratic InOut",
            "Cubic In",
            "Cubic Out",
            "Cubic InOut",
            "Quartic In",
            "Quartic Out",
            "Quartic InOut",
            "Quintic In",
            "Quintic Out",
            "Quintic InOut",
            "Exponential In",
            "Exponential Out",
            "Exponential InOut",
            "Circular In",
            "Circular Out",
            "Circular InOut",
            "Overshoot In",
            "Overshoot Out",
            "Overshoot InOut",
            "Elastic In",
            "Elastic Out",
            "Elastic InOut",
            "Bounce In",
            "Bounce Out",
            "Bounce InOut"});
            this.comboBox_Type.Location = new System.Drawing.Point(15, 38);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(172, 21);
            this.comboBox_Type.TabIndex = 2;
            // 
            // button_1to2
            // 
            this.button_1to2.Location = new System.Drawing.Point(193, 10);
            this.button_1to2.Name = "button_1to2";
            this.button_1to2.Size = new System.Drawing.Size(156, 22);
            this.button_1to2.TabIndex = 3;
            this.button_1to2.Text = "1 -> 2";
            this.button_1to2.UseVisualStyleBackColor = true;
            this.button_1to2.Click += new System.EventHandler(this.Button_1to2_Click);
            // 
            // button_2to1
            // 
            this.button_2to1.Location = new System.Drawing.Point(193, 38);
            this.button_2to1.Name = "button_2to1";
            this.button_2to1.Size = new System.Drawing.Size(156, 22);
            this.button_2to1.TabIndex = 3;
            this.button_2to1.Text = "1 <- 2";
            this.button_2to1.UseVisualStyleBackColor = true;
            this.button_2to1.Click += new System.EventHandler(this.Button_2to1_Click);
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(41, 65);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(50, 20);
            this.textBox_x1.TabIndex = 4;
            // 
            // textBox_y1
            // 
            this.textBox_y1.Location = new System.Drawing.Point(41, 91);
            this.textBox_y1.Name = "textBox_y1";
            this.textBox_y1.Size = new System.Drawing.Size(50, 20);
            this.textBox_y1.TabIndex = 4;
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(41, 127);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(50, 20);
            this.textBox_x2.TabIndex = 4;
            // 
            // textBox_y2
            // 
            this.textBox_y2.Location = new System.Drawing.Point(41, 153);
            this.textBox_y2.Name = "textBox_y2";
            this.textBox_y2.Size = new System.Drawing.Size(50, 20);
            this.textBox_y2.TabIndex = 4;
            // 
            // textBox_w1
            // 
            this.textBox_w1.Location = new System.Drawing.Point(218, 65);
            this.textBox_w1.Name = "textBox_w1";
            this.textBox_w1.Size = new System.Drawing.Size(50, 20);
            this.textBox_w1.TabIndex = 4;
            // 
            // textBox_h1
            // 
            this.textBox_h1.Location = new System.Drawing.Point(218, 91);
            this.textBox_h1.Name = "textBox_h1";
            this.textBox_h1.Size = new System.Drawing.Size(50, 20);
            this.textBox_h1.TabIndex = 4;
            // 
            // textBox_w2
            // 
            this.textBox_w2.Location = new System.Drawing.Point(218, 125);
            this.textBox_w2.Name = "textBox_w2";
            this.textBox_w2.Size = new System.Drawing.Size(50, 20);
            this.textBox_w2.TabIndex = 4;
            // 
            // textBox_h2
            // 
            this.textBox_h2.Location = new System.Drawing.Point(218, 151);
            this.textBox_h2.Name = "textBox_h2";
            this.textBox_h2.Size = new System.Drawing.Size(50, 20);
            this.textBox_h2.TabIndex = 4;
            // 
            // label_x1
            // 
            this.label_x1.AutoSize = true;
            this.label_x1.Location = new System.Drawing.Point(17, 68);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(18, 13);
            this.label_x1.TabIndex = 5;
            this.label_x1.Text = "x1";
            // 
            // label_y1
            // 
            this.label_y1.AutoSize = true;
            this.label_y1.Location = new System.Drawing.Point(17, 94);
            this.label_y1.Name = "label_y1";
            this.label_y1.Size = new System.Drawing.Size(18, 13);
            this.label_y1.TabIndex = 5;
            this.label_y1.Text = "y1";
            // 
            // label_x2
            // 
            this.label_x2.AutoSize = true;
            this.label_x2.Location = new System.Drawing.Point(20, 130);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(18, 13);
            this.label_x2.TabIndex = 5;
            this.label_x2.Text = "x2";
            // 
            // label_y2
            // 
            this.label_y2.AutoSize = true;
            this.label_y2.Location = new System.Drawing.Point(20, 156);
            this.label_y2.Name = "label_y2";
            this.label_y2.Size = new System.Drawing.Size(18, 13);
            this.label_y2.TabIndex = 5;
            this.label_y2.Text = "y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "w1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "h1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "w2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "h2";
            // 
            // button_SetLoc1
            // 
            this.button_SetLoc1.Location = new System.Drawing.Point(97, 65);
            this.button_SetLoc1.Name = "button_SetLoc1";
            this.button_SetLoc1.Size = new System.Drawing.Size(75, 46);
            this.button_SetLoc1.TabIndex = 3;
            this.button_SetLoc1.Text = "Set Location 1";
            this.button_SetLoc1.UseVisualStyleBackColor = true;
            this.button_SetLoc1.Click += new System.EventHandler(this.Button_SetLoc1_Click);
            // 
            // button_SetLoc2
            // 
            this.button_SetLoc2.Location = new System.Drawing.Point(97, 125);
            this.button_SetLoc2.Name = "button_SetLoc2";
            this.button_SetLoc2.Size = new System.Drawing.Size(75, 48);
            this.button_SetLoc2.TabIndex = 3;
            this.button_SetLoc2.Text = "Set Location 2";
            this.button_SetLoc2.UseVisualStyleBackColor = true;
            this.button_SetLoc2.Click += new System.EventHandler(this.Button_SetLoc2_Click);
            // 
            // button_SetSize1
            // 
            this.button_SetSize1.Location = new System.Drawing.Point(274, 65);
            this.button_SetSize1.Name = "button_SetSize1";
            this.button_SetSize1.Size = new System.Drawing.Size(75, 46);
            this.button_SetSize1.TabIndex = 3;
            this.button_SetSize1.Text = "Set Size 1";
            this.button_SetSize1.UseVisualStyleBackColor = true;
            this.button_SetSize1.Click += new System.EventHandler(this.Button_SetSize1_Click);
            // 
            // button_SetSize2
            // 
            this.button_SetSize2.Location = new System.Drawing.Point(274, 125);
            this.button_SetSize2.Name = "button_SetSize2";
            this.button_SetSize2.Size = new System.Drawing.Size(75, 46);
            this.button_SetSize2.TabIndex = 3;
            this.button_SetSize2.Text = "Set Size 2";
            this.button_SetSize2.UseVisualStyleBackColor = true;
            this.button_SetSize2.Click += new System.EventHandler(this.Button_SetSize2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 186);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_y2);
            this.Controls.Add(this.label_x2);
            this.Controls.Add(this.label_y1);
            this.Controls.Add(this.label_x1);
            this.Controls.Add(this.textBox_h2);
            this.Controls.Add(this.textBox_h1);
            this.Controls.Add(this.textBox_y2);
            this.Controls.Add(this.textBox_y1);
            this.Controls.Add(this.textBox_w2);
            this.Controls.Add(this.textBox_w1);
            this.Controls.Add(this.textBox_x2);
            this.Controls.Add(this.textBox_x1);
            this.Controls.Add(this.button_SetLoc2);
            this.Controls.Add(this.button_2to1);
            this.Controls.Add(this.button_SetSize2);
            this.Controls.Add(this.button_SetSize1);
            this.Controls.Add(this.button_SetLoc1);
            this.Controls.Add(this.button_1to2);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Duration);
            this.MinimumSize = new System.Drawing.Size(380, 225);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easings";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Button button_1to2;
        private System.Windows.Forms.Button button_2to1;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_y1;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.TextBox textBox_y2;
        private System.Windows.Forms.TextBox textBox_w1;
        private System.Windows.Forms.TextBox textBox_h1;
        private System.Windows.Forms.TextBox textBox_w2;
        private System.Windows.Forms.TextBox textBox_h2;
        private System.Windows.Forms.Label label_x1;
        private System.Windows.Forms.Label label_y1;
        private System.Windows.Forms.Label label_x2;
        private System.Windows.Forms.Label label_y2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_SetLoc1;
        private System.Windows.Forms.Button button_SetLoc2;
        private System.Windows.Forms.Button button_SetSize1;
        private System.Windows.Forms.Button button_SetSize2;
    }
}

