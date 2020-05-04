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
            this.search_bt = new System.Windows.Forms.Button();
            this.banner_pic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_bt
            // 
            this.connect_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_bt.ForeColor = System.Drawing.Color.Black;
            this.connect_bt.Location = new System.Drawing.Point(437, 209);
            this.connect_bt.Name = "connect_bt";
            this.connect_bt.Size = new System.Drawing.Size(96, 38);
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
            this.status_lb.Location = new System.Drawing.Point(175, 331);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(0, 20);
            this.status_lb.TabIndex = 12;
            // 
            // url_tb
            // 
            this.url_tb.Enabled = false;
            this.url_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_tb.HideSelection = false;
            this.url_tb.Location = new System.Drawing.Point(178, 284);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(268, 23);
            this.url_tb.TabIndex = 14;
            this.url_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // ip_lb
            // 
            this.ip_lb.AutoSize = true;
            this.ip_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_lb.Location = new System.Drawing.Point(93, 194);
            this.ip_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_lb.Name = "ip_lb";
            this.ip_lb.Size = new System.Drawing.Size(76, 17);
            this.ip_lb.TabIndex = 17;
            this.ip_lb.Text = "IP Address";
            // 
            // ip_tb
            // 
            this.ip_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_tb.Location = new System.Drawing.Point(178, 192);
            this.ip_tb.Margin = new System.Windows.Forms.Padding(2);
            this.ip_tb.Name = "ip_tb";
            this.ip_tb.Size = new System.Drawing.Size(177, 23);
            this.ip_tb.TabIndex = 18;
            this.ip_tb.Text = "127.0.0.1";
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(178, 238);
            this.port_tb.Margin = new System.Windows.Forms.Padding(2);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(78, 23);
            this.port_tb.TabIndex = 20;
            this.port_tb.Text = "8080";
            // 
            // port_lb
            // 
            this.port_lb.AutoSize = true;
            this.port_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_lb.Location = new System.Drawing.Point(93, 240);
            this.port_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.port_lb.Name = "port_lb";
            this.port_lb.Size = new System.Drawing.Size(34, 17);
            this.port_lb.TabIndex = 19;
            this.port_lb.Text = "Port";
            // 
            // url_lb
            // 
            this.url_lb.AutoSize = true;
            this.url_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_lb.Location = new System.Drawing.Point(93, 284);
            this.url_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.url_lb.Name = "url_lb";
            this.url_lb.Size = new System.Drawing.Size(36, 17);
            this.url_lb.TabIndex = 21;
            this.url_lb.Text = "URL";
            // 
            // search_bt
            // 
            this.search_bt.Enabled = false;
            this.search_bt.Image = global::Client.Properties.Resources.search15x15;
            this.search_bt.Location = new System.Drawing.Point(474, 283);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(59, 25);
            this.search_bt.TabIndex = 16;
            this.search_bt.UseVisualStyleBackColor = true;
            this.search_bt.Click += new System.EventHandler(this.search_button_Click);
            // 
            // banner_pic
            // 
            this.banner_pic.Image = ((System.Drawing.Image)(resources.GetObject("banner_pic.Image")));
            this.banner_pic.Location = new System.Drawing.Point(92, 10);
            this.banner_pic.Margin = new System.Windows.Forms.Padding(2);
            this.banner_pic.Name = "banner_pic";
            this.banner_pic.Size = new System.Drawing.Size(492, 162);
            this.banner_pic.TabIndex = 13;
            this.banner_pic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "About us";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 400);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client";
            this.RightToLeftLayout = true;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
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
        private System.Windows.Forms.Button button1;
    }
}

