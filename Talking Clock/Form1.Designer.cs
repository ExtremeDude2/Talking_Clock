namespace Talking_Clock
{
    partial class talkingClock
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
            this.textBox_in = new System.Windows.Forms.TextBox();
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.label_in = new System.Windows.Forms.Label();
            this.label_out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_in
            // 
            this.textBox_in.Location = new System.Drawing.Point(12, 29);
            this.textBox_in.Name = "textBox_in";
            this.textBox_in.Size = new System.Drawing.Size(100, 20);
            this.textBox_in.TabIndex = 0;
            this.textBox_in.TextChanged += new System.EventHandler(this.textBox_in_TextChanged);
            // 
            // textBox_out
            // 
            this.textBox_out.Location = new System.Drawing.Point(172, 29);
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.Size = new System.Drawing.Size(100, 20);
            this.textBox_out.TabIndex = 1;
            // 
            // label_in
            // 
            this.label_in.AutoSize = true;
            this.label_in.Location = new System.Drawing.Point(13, 13);
            this.label_in.Name = "label_in";
            this.label_in.Size = new System.Drawing.Size(59, 13);
            this.label_in.TabIndex = 2;
            this.label_in.Text = "Input (time)";
            // 
            // label_out
            // 
            this.label_out.AutoSize = true;
            this.label_out.Location = new System.Drawing.Point(172, 12);
            this.label_out.Name = "label_out";
            this.label_out.Size = new System.Drawing.Size(65, 13);
            this.label_out.TabIndex = 3;
            this.label_out.Text = "Output (text)";
            // 
            // talkingClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_out);
            this.Controls.Add(this.label_in);
            this.Controls.Add(this.textBox_out);
            this.Controls.Add(this.textBox_in);
            this.Name = "talkingClock";
            this.Text = "Talking CLock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_in;
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.Label label_in;
        private System.Windows.Forms.Label label_out;
    }
}

