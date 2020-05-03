namespace Server
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
            this.log_tb = new System.Windows.Forms.TextBox();
            this.banner_pic = new System.Windows.Forms.PictureBox();
            this.listen_bt = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // log_tb
            // 
            this.log_tb.Location = new System.Drawing.Point(100, 256);
            this.log_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.log_tb.Multiline = true;
            this.log_tb.Name = "log_tb";
            this.log_tb.ReadOnly = true;
            this.log_tb.Size = new System.Drawing.Size(457, 145);
            this.log_tb.TabIndex = 4;
            this.log_tb.Text = "Waiting for a connection...";
            this.log_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // banner_pic
            // 
            this.banner_pic.Image = global::Server.Properties.Resources.Open_Web_Away_;
            this.banner_pic.Location = new System.Drawing.Point(130, 58);
            this.banner_pic.Name = "banner_pic";
            this.banner_pic.Size = new System.Drawing.Size(700, 191);
            this.banner_pic.TabIndex = 8;
            this.banner_pic.TabStop = false;
            this.banner_pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listen_bt
            // 
            this.listen_bt.Location = new System.Drawing.Point(603, 256);
            this.listen_bt.Name = "listen_bt";
            this.listen_bt.Size = new System.Drawing.Size(174, 58);
            this.listen_bt.TabIndex = 9;
            this.listen_bt.Text = "Listen";
            this.listen_bt.UseVisualStyleBackColor = true;
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(603, 343);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(174, 58);
            this.stop_button.TabIndex = 10;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 500);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.listen_bt);
            this.Controls.Add(this.banner_pic);
            this.Controls.Add(this.log_tb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox log_tb;
        private System.Windows.Forms.PictureBox banner_pic;
        private System.Windows.Forms.Button listen_bt;
        private System.Windows.Forms.Button stop_button;
    }
}

