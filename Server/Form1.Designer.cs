namespace Server
{
    partial class Server
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
            this.start_bt = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.port_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // log_tb
            // 
            this.log_tb.Location = new System.Drawing.Point(128, 292);
            this.log_tb.Margin = new System.Windows.Forms.Padding(4);
            this.log_tb.Multiline = true;
            this.log_tb.Name = "log_tb";
            this.log_tb.ReadOnly = true;
            this.log_tb.Size = new System.Drawing.Size(457, 145);
            this.log_tb.TabIndex = 4;
            this.log_tb.Text = "Waiting for a connection...";
            // 
            // banner_pic
            // 
            this.banner_pic.Image = global::Server.Properties.Resources.Open_Web_Away_;
            this.banner_pic.Location = new System.Drawing.Point(128, 28);
            this.banner_pic.Name = "banner_pic";
            this.banner_pic.Size = new System.Drawing.Size(700, 191);
            this.banner_pic.TabIndex = 8;
            this.banner_pic.TabStop = false;
            // 
            // start_bt
            // 
            this.start_bt.Location = new System.Drawing.Point(601, 292);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(174, 58);
            this.start_bt.TabIndex = 9;
            this.start_bt.Text = "Start";
            this.start_bt.UseVisualStyleBackColor = true;
            this.start_bt.Click += new System.EventHandler(this.start_bt_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(601, 379);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(174, 58);
            this.stop_button.TabIndex = 10;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(232, 241);
            this.port_tb.Multiline = true;
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(172, 41);
            this.port_tb.TabIndex = 22;
            this.port_tb.Text = "8080";
            // 
            // port_lb
            // 
            this.port_lb.AutoSize = true;
            this.port_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_lb.Location = new System.Drawing.Point(129, 244);
            this.port_lb.Name = "port_lb";
            this.port_lb.Size = new System.Drawing.Size(40, 20);
            this.port_lb.TabIndex = 21;
            this.port_lb.Text = "Port";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 500);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.port_lb);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_bt);
            this.Controls.Add(this.banner_pic);
            this.Controls.Add(this.log_tb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox log_tb;
        private System.Windows.Forms.PictureBox banner_pic;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Label port_lb;
    }
}

