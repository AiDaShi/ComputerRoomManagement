namespace ComputerRoomClient
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelMediaSubmenu = new System.Windows.Forms.Panel();
            this.ServerSettingBtn = new System.Windows.Forms.Button();
            this.LocationSettingBtn = new System.Windows.Forms.Button();
            this.LocationStateBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogUILable = new System.Windows.Forms.TextBox();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMediaSubmenu.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.ExitBtn);
            this.panelSideMenu.Controls.Add(this.panelMediaSubmenu);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 600);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedia.Location = new System.Drawing.Point(0, 100);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(250, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Option Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelMediaSubmenu
            // 
            this.panelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubmenu.Controls.Add(this.LocationStateBtn);
            this.panelMediaSubmenu.Controls.Add(this.LocationSettingBtn);
            this.panelMediaSubmenu.Controls.Add(this.ServerSettingBtn);
            this.panelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelMediaSubmenu.Name = "panelMediaSubmenu";
            this.panelMediaSubmenu.Size = new System.Drawing.Size(250, 139);
            this.panelMediaSubmenu.TabIndex = 2;
            this.panelMediaSubmenu.Visible = false;
            // 
            // ServerSettingBtn
            // 
            this.ServerSettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServerSettingBtn.FlatAppearance.BorderSize = 0;
            this.ServerSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerSettingBtn.ForeColor = System.Drawing.Color.LightGray;
            this.ServerSettingBtn.Location = new System.Drawing.Point(0, 0);
            this.ServerSettingBtn.Name = "ServerSettingBtn";
            this.ServerSettingBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ServerSettingBtn.Size = new System.Drawing.Size(250, 45);
            this.ServerSettingBtn.TabIndex = 0;
            this.ServerSettingBtn.Text = "Server Setting";
            this.ServerSettingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServerSettingBtn.UseVisualStyleBackColor = true;
            this.ServerSettingBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LocationSettingBtn
            // 
            this.LocationSettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationSettingBtn.FlatAppearance.BorderSize = 0;
            this.LocationSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationSettingBtn.ForeColor = System.Drawing.Color.LightGray;
            this.LocationSettingBtn.Location = new System.Drawing.Point(0, 45);
            this.LocationSettingBtn.Name = "LocationSettingBtn";
            this.LocationSettingBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.LocationSettingBtn.Size = new System.Drawing.Size(250, 45);
            this.LocationSettingBtn.TabIndex = 1;
            this.LocationSettingBtn.Text = "Location Setting";
            this.LocationSettingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocationSettingBtn.UseVisualStyleBackColor = true;
            this.LocationSettingBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // LocationStateBtn
            // 
            this.LocationStateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationStateBtn.FlatAppearance.BorderSize = 0;
            this.LocationStateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationStateBtn.ForeColor = System.Drawing.Color.LightGray;
            this.LocationStateBtn.Location = new System.Drawing.Point(0, 90);
            this.LocationStateBtn.Name = "LocationStateBtn";
            this.LocationStateBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.LocationStateBtn.Size = new System.Drawing.Size(250, 45);
            this.LocationStateBtn.TabIndex = 2;
            this.LocationStateBtn.Text = "Location State";
            this.LocationStateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocationStateBtn.UseVisualStyleBackColor = true;
            this.LocationStateBtn.Click += new System.EventHandler(this.LocationStateBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitBtn.Location = new System.Drawing.Point(0, 284);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitBtn.Size = new System.Drawing.Size(250, 45);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelPlayer.Controls.Add(this.LogUILable);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 452);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(700, 148);
            this.panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(700, 452);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.panelChildForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computer Room Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "20%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "30%";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 148);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComputerRoomClient.Properties.Resources.check;
            this.pictureBox1.Location = new System.Drawing.Point(280, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ComputerRoomClient.Properties.Resources.BlackServer;
            this.pictureBox5.Location = new System.Drawing.Point(173, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 50);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ComputerRoomClient.Properties.Resources.host_cpu;
            this.pictureBox3.Location = new System.Drawing.Point(26, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 49);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ComputerRoomClient.Properties.Resources.Memory;
            this.pictureBox4.Location = new System.Drawing.Point(26, 74);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 50);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ComputerRoomClient.Properties.Resources.checksmall2;
            this.pictureBox2.Location = new System.Drawing.Point(90, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 65);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // LogUILable
            // 
            this.LogUILable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.LogUILable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogUILable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogUILable.ForeColor = System.Drawing.Color.BlueViolet;
            this.LogUILable.Location = new System.Drawing.Point(0, 0);
            this.LogUILable.Multiline = true;
            this.LogUILable.Name = "LogUILable";
            this.LogUILable.Size = new System.Drawing.Size(700, 148);
            this.LogUILable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelMediaSubmenu.ResumeLayout(false);
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMediaSubmenu;
        private System.Windows.Forms.Button LocationStateBtn;
        private System.Windows.Forms.Button LocationSettingBtn;
        private System.Windows.Forms.Button ServerSettingBtn;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.TextBox LogUILable;
    }
}

