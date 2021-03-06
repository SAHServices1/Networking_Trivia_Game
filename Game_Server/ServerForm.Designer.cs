﻿namespace Game_Server
{
    partial class ServerForm
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
            this.clientListTxt = new System.Windows.Forms.TextBox();
            this.startSrvBtn = new System.Windows.Forms.Button();
            this.stopSrvBtn = new System.Windows.Forms.Button();
            this.srvConslTxt = new System.Windows.Forms.TextBox();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.extBtn = new System.Windows.Forms.Button();
            this.chatInptTxt = new System.Windows.Forms.TextBox();
            this.sndBtn = new System.Windows.Forms.Button();
            this.maxQNumtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientListTxt
            // 
            this.clientListTxt.Location = new System.Drawing.Point(12, 74);
            this.clientListTxt.Multiline = true;
            this.clientListTxt.Name = "clientListTxt";
            this.clientListTxt.ReadOnly = true;
            this.clientListTxt.Size = new System.Drawing.Size(121, 165);
            this.clientListTxt.TabIndex = 0;
            this.clientListTxt.TextChanged += new System.EventHandler(this.clientListTxt_TextChanged);
            // 
            // startSrvBtn
            // 
            this.startSrvBtn.Location = new System.Drawing.Point(12, 12);
            this.startSrvBtn.Name = "startSrvBtn";
            this.startSrvBtn.Size = new System.Drawing.Size(121, 25);
            this.startSrvBtn.TabIndex = 1;
            this.startSrvBtn.Text = "Start server";
            this.startSrvBtn.UseVisualStyleBackColor = true;
            this.startSrvBtn.Click += new System.EventHandler(this.startSrvBtn_Click);
            // 
            // stopSrvBtn
            // 
            this.stopSrvBtn.Enabled = false;
            this.stopSrvBtn.Location = new System.Drawing.Point(12, 43);
            this.stopSrvBtn.Name = "stopSrvBtn";
            this.stopSrvBtn.Size = new System.Drawing.Size(121, 25);
            this.stopSrvBtn.TabIndex = 2;
            this.stopSrvBtn.Text = "Stop server";
            this.stopSrvBtn.UseVisualStyleBackColor = true;
            this.stopSrvBtn.Click += new System.EventHandler(this.stopSrvBtn_Click);
            // 
            // srvConslTxt
            // 
            this.srvConslTxt.Location = new System.Drawing.Point(139, 12);
            this.srvConslTxt.Multiline = true;
            this.srvConslTxt.Name = "srvConslTxt";
            this.srvConslTxt.ReadOnly = true;
            this.srvConslTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.srvConslTxt.Size = new System.Drawing.Size(327, 281);
            this.srvConslTxt.TabIndex = 3;
            this.srvConslTxt.TextChanged += new System.EventHandler(this.srvConslTxt_TextChanged);
            // 
            // startGameBtn
            // 
            this.startGameBtn.Enabled = false;
            this.startGameBtn.Location = new System.Drawing.Point(12, 268);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(121, 25);
            this.startGameBtn.TabIndex = 4;
            this.startGameBtn.Text = "Start game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // extBtn
            // 
            this.extBtn.Location = new System.Drawing.Point(12, 299);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(121, 25);
            this.extBtn.TabIndex = 5;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // chatInptTxt
            // 
            this.chatInptTxt.Location = new System.Drawing.Point(222, 302);
            this.chatInptTxt.Name = "chatInptTxt";
            this.chatInptTxt.Size = new System.Drawing.Size(244, 20);
            this.chatInptTxt.TabIndex = 6;
            // 
            // sndBtn
            // 
            this.sndBtn.Enabled = false;
            this.sndBtn.Location = new System.Drawing.Point(139, 299);
            this.sndBtn.Name = "sndBtn";
            this.sndBtn.Size = new System.Drawing.Size(77, 25);
            this.sndBtn.TabIndex = 7;
            this.sndBtn.Text = "Send";
            this.sndBtn.UseVisualStyleBackColor = true;
            this.sndBtn.Click += new System.EventHandler(this.sndBtn_Click);
            // 
            // maxQNumtxt
            // 
            this.maxQNumtxt.Location = new System.Drawing.Point(112, 245);
            this.maxQNumtxt.MaxLength = 2;
            this.maxQNumtxt.Name = "maxQNumtxt";
            this.maxQNumtxt.Size = new System.Drawing.Size(21, 20);
            this.maxQNumtxt.TabIndex = 8;
            this.maxQNumtxt.Text = "5";
            this.maxQNumtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxQNumtxt.TextChanged += new System.EventHandler(this.maxQNumtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of questions";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxQNumtxt);
            this.Controls.Add(this.sndBtn);
            this.Controls.Add(this.chatInptTxt);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.srvConslTxt);
            this.Controls.Add(this.stopSrvBtn);
            this.Controls.Add(this.startSrvBtn);
            this.Controls.Add(this.clientListTxt);
            this.Name = "ServerForm";
            this.Text = "Networking Game Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientListTxt;
        private System.Windows.Forms.Button startSrvBtn;
        private System.Windows.Forms.Button stopSrvBtn;
        private System.Windows.Forms.TextBox srvConslTxt;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.TextBox chatInptTxt;
        private System.Windows.Forms.Button sndBtn;
        private System.Windows.Forms.TextBox maxQNumtxt;
        private System.Windows.Forms.Label label1;

    }
}

