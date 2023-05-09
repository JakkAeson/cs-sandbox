namespace Sync
{
    partial class Form2
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
            this.button_Update = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.textBox_Sync = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(12, 29);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(13, 13);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(35, 13);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "label1";
            // 
            // textBox_Sync
            // 
            this.textBox_Sync.Location = new System.Drawing.Point(12, 129);
            this.textBox_Sync.Name = "textBox_Sync";
            this.textBox_Sync.Size = new System.Drawing.Size(360, 20);
            this.textBox_Sync.TabIndex = 2;
            this.textBox_Sync.TextChanged += new System.EventHandler(this.TextBox_Sync_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.textBox_Sync);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label_Message);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Update;
        public System.Windows.Forms.Label label_Message;
        public System.Windows.Forms.TextBox textBox_Sync;
    }
}