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
            this.url_tb = new System.Windows.Forms.TextBox();
            this.connect_bt = new System.Windows.Forms.Button();
            this.status_lb = new System.Windows.Forms.Label();
            this.banner_pic = new System.Windows.Forms.PictureBox();
            this.search_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // url_tb
            // 
            this.url_tb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_tb.Location = new System.Drawing.Point(169, 276);
            this.url_tb.Margin = new System.Windows.Forms.Padding(4);
            this.url_tb.Multiline = true;
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(356, 41);
            this.url_tb.TabIndex = 0;
            this.url_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // connect_bt
            // 
            this.connect_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_bt.ForeColor = System.Drawing.Color.Black;
            this.connect_bt.Location = new System.Drawing.Point(674, 273);
            this.connect_bt.Margin = new System.Windows.Forms.Padding(4);
            this.connect_bt.Name = "connect_bt";
            this.connect_bt.Size = new System.Drawing.Size(111, 47);
            this.connect_bt.TabIndex = 4;
            this.connect_bt.Text = "Connect";
            this.connect_bt.UseVisualStyleBackColor = true;
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lb.ForeColor = System.Drawing.Color.ForestGreen;
            this.status_lb.Location = new System.Drawing.Point(373, 372);
            this.status_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(119, 25);
            this.status_lb.TabIndex = 12;
            this.status_lb.Text = "Successful !";
            // 
            // banner_pic
            // 
            this.banner_pic.Image = ((System.Drawing.Image)(resources.GetObject("banner_pic.Image")));
            this.banner_pic.Location = new System.Drawing.Point(169, 67);
            this.banner_pic.Name = "banner_pic";
            this.banner_pic.Size = new System.Drawing.Size(656, 200);
            this.banner_pic.TabIndex = 13;
            this.banner_pic.TabStop = false;
            // 
            // search_bt
            // 
            this.search_bt.Image = global::Client.Properties.Resources.search32x32;
            this.search_bt.Location = new System.Drawing.Point(549, 273);
            this.search_bt.Margin = new System.Windows.Forms.Padding(4);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(90, 47);
            this.search_bt.TabIndex = 11;
            this.search_bt.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 500);
            this.Controls.Add(this.banner_pic);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.connect_bt);
            this.Controls.Add(this.url_tb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client";
            this.RightToLeftLayout = true;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Button connect_bt;
        private System.Windows.Forms.Button search_bt;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.PictureBox banner_pic;
    }
}

