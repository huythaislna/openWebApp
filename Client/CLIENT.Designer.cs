namespace Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.connect_bt = new System.Windows.Forms.Button();
            this.status_lb = new System.Windows.Forms.Label();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.ip_lb = new System.Windows.Forms.Label();
            this.ip_tb = new System.Windows.Forms.TextBox();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.port_lb = new System.Windows.Forms.Label();
            this.url_lb = new System.Windows.Forms.Label();
            this.about_bt = new System.Windows.Forms.Button();
            this.search_bt = new System.Windows.Forms.Button();
            this.banner_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_bt
            // 
            this.connect_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_bt.ForeColor = System.Drawing.Color.Black;
            this.connect_bt.Location = new System.Drawing.Point(583, 257);
            this.connect_bt.Margin = new System.Windows.Forms.Padding(4);
            this.connect_bt.Name = "connect_bt";
            this.connect_bt.Size = new System.Drawing.Size(128, 47);
            this.connect_bt.TabIndex = 4;
            this.connect_bt.Text = "Connect";
            this.connect_bt.UseVisualStyleBackColor = true;
            this.connect_bt.Click += new System.EventHandler(this.connect_bt_Click);
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lb.ForeColor = System.Drawing.Color.ForestGreen;
            this.status_lb.Location = new System.Drawing.Point(233, 407);
            this.status_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(0, 25);
            this.status_lb.TabIndex = 12;
            // 
            // url_tb
            // 
            this.url_tb.Enabled = false;
            this.url_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_tb.HideSelection = false;
            this.url_tb.Location = new System.Drawing.Point(237, 350);
            this.url_tb.Margin = new System.Windows.Forms.Padding(4);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(356, 27);
            this.url_tb.TabIndex = 14;
            this.url_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // ip_lb
            // 
            this.ip_lb.AutoSize = true;
            this.ip_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_lb.Location = new System.Drawing.Point(124, 239);
            this.ip_lb.Name = "ip_lb";
            this.ip_lb.Size = new System.Drawing.Size(91, 20);
            this.ip_lb.TabIndex = 17;
            this.ip_lb.Text = "IP Address";
            // 
            // ip_tb
            // 
            this.ip_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_tb.Location = new System.Drawing.Point(237, 236);
            this.ip_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ip_tb.Name = "ip_tb";
            this.ip_tb.Size = new System.Drawing.Size(235, 27);
            this.ip_tb.TabIndex = 18;
            this.ip_tb.Text = "127.0.0.1";
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(237, 293);
            this.port_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(103, 27);
            this.port_tb.TabIndex = 20;
            this.port_tb.Text = "8080";
            // 
            // port_lb
            // 
            this.port_lb.AutoSize = true;
            this.port_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_lb.Location = new System.Drawing.Point(124, 295);
            this.port_lb.Name = "port_lb";
            this.port_lb.Size = new System.Drawing.Size(40, 20);
            this.port_lb.TabIndex = 19;
            this.port_lb.Text = "Port";
            // 
            // url_lb
            // 
            this.url_lb.AutoSize = true;
            this.url_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_lb.Location = new System.Drawing.Point(124, 350);
            this.url_lb.Name = "url_lb";
            this.url_lb.Size = new System.Drawing.Size(43, 20);
            this.url_lb.TabIndex = 21;
            this.url_lb.Text = "URL";
            // 
            // about_bt
            // 
            this.about_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_bt.Location = new System.Drawing.Point(0, 0);
            this.about_bt.Margin = new System.Windows.Forms.Padding(4);
            this.about_bt.Name = "about_bt";
            this.about_bt.Size = new System.Drawing.Size(96, 46);
            this.about_bt.TabIndex = 22;
            this.about_bt.Text = "About us";
            this.about_bt.UseVisualStyleBackColor = true;
            this.about_bt.Click += new System.EventHandler(this.about_bt_Click);
            // 
            // search_bt
            // 
            this.search_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_bt.Enabled = false;
            this.search_bt.Image = global::Client.Properties.Resources.search15x15;
            this.search_bt.Location = new System.Drawing.Point(632, 348);
            this.search_bt.Margin = new System.Windows.Forms.Padding(4);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(79, 31);
            this.search_bt.TabIndex = 16;
            this.search_bt.UseVisualStyleBackColor = true;
            this.search_bt.Click += new System.EventHandler(this.search_button_Click);
            // 
            // banner_pic
            // 
            this.banner_pic.Image = ((System.Drawing.Image)(resources.GetObject("banner_pic.Image")));
            this.banner_pic.Location = new System.Drawing.Point(123, 12);
            this.banner_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banner_pic.Name = "banner_pic";
            this.banner_pic.Size = new System.Drawing.Size(656, 199);
            this.banner_pic.TabIndex = 13;
            this.banner_pic.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 492);
            this.Controls.Add(this.about_bt);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.url_lb);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.port_lb);
            this.Controls.Add(this.ip_tb);
            this.Controls.Add(this.ip_lb);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.url_tb);
            this.Controls.Add(this.banner_pic);
            this.Controls.Add(this.connect_bt);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client";
            this.RightToLeftLayout = true;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connect_bt;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.PictureBox banner_pic;
        private System.Windows.Forms.Button search_bt;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Label ip_lb;
        private System.Windows.Forms.TextBox ip_tb;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Label port_lb;
        private System.Windows.Forms.Label url_lb;
        private System.Windows.Forms.Button about_bt;
    }
}

