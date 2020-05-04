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
            this.banner_pic = new System.Windows.Forms.PictureBox();
            this.start_bt = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.port_lb = new System.Windows.Forms.Label();
            this.log_tb = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urlprocess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // banner_pic
            // 
            this.banner_pic.Image = global::Server.Properties.Resources.Open_Web_Away_;
            this.banner_pic.Location = new System.Drawing.Point(108, 27);
            this.banner_pic.Name = "banner_pic";
            this.banner_pic.Size = new System.Drawing.Size(700, 191);
            this.banner_pic.TabIndex = 8;
            this.banner_pic.TabStop = false;
            // 
            // start_bt
            // 
            this.start_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_bt.Location = new System.Drawing.Point(750, 312);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(141, 58);
            this.start_bt.TabIndex = 9;
            this.start_bt.Text = "Start";
            this.start_bt.UseVisualStyleBackColor = true;
            this.start_bt.Click += new System.EventHandler(this.start_bt_Click);
            // 
            // stop_button
            // 
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_button.Location = new System.Drawing.Point(750, 411);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(141, 58);
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
            this.port_tb.Size = new System.Drawing.Size(90, 23);
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
            // log_tb
            // 
            this.log_tb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.log_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_tb.FullRowSelect = true;
            this.log_tb.Location = new System.Drawing.Point(35, 312);
            this.log_tb.Name = "log_tb";
            this.log_tb.Size = new System.Drawing.Size(696, 157);
            this.log_tb.TabIndex = 23;
            this.log_tb.UseCompatibleStateImageBehavior = false;
            this.log_tb.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DATA";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "STATUS";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ADDRESS";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TIME";
            this.columnHeader4.Width = 150;
            // 
            // urlprocess
            // 
            this.urlprocess.AutoSize = true;
            this.urlprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlprocess.ForeColor = System.Drawing.Color.Blue;
            this.urlprocess.Location = new System.Drawing.Point(272, 275);
            this.urlprocess.Name = "urlprocess";
            this.urlprocess.Size = new System.Drawing.Size(0, 20);
            this.urlprocess.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "URL Processing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(782, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "OFF";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlprocess);
            this.Controls.Add(this.log_tb);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.port_lb);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_bt);
            this.Controls.Add(this.banner_pic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.banner_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox banner_pic;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Label port_lb;
        private System.Windows.Forms.ListView log_tb;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label urlprocess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

