namespace ComputerRoomClient
{
    partial class ServerSettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputIP = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.InputPort = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // InputIP
            // 
            this.InputIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.InputIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputIP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.InputIP.Location = new System.Drawing.Point(163, 126);
            this.InputIP.Multiline = true;
            this.InputIP.Name = "InputIP";
            this.InputIP.Size = new System.Drawing.Size(225, 27);
            this.InputIP.TabIndex = 3;
            this.InputIP.Text = "IP...";
            this.InputIP.Click += new System.EventHandler(this.InputIP_Click);
            this.InputIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputIP_KeyDown);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(182, 308);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(185, 40);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "SAVE / POST";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // InputPort
            // 
            this.InputPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.InputPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPort.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.InputPort.Location = new System.Drawing.Point(163, 173);
            this.InputPort.Multiline = true;
            this.InputPort.Name = "InputPort";
            this.InputPort.Size = new System.Drawing.Size(225, 27);
            this.InputPort.TabIndex = 5;
            this.InputPort.Text = "Port...";
            // 
            // ClientName
            // 
            this.ClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientName.Location = new System.Drawing.Point(163, 224);
            this.ClientName.Multiline = true;
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(225, 27);
            this.ClientName.TabIndex = 7;
            this.ClientName.Text = "ClientName...";
            // 
            // ServerSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(700, 466);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.InputPort);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.InputIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerSettingForm";
            this.Text = "ServerSettingForm";
            this.Load += new System.EventHandler(this.ServerSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputIP;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox InputPort;
        private System.Windows.Forms.TextBox ClientName;
    }
}