﻿namespace Database_project
{
    partial class USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pss_txt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_email = new System.Windows.Forms.TextBox();
            this.user_pass = new System.Windows.Forms.TextBox();
            this.admin_login = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(140, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 144);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(144, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOG IN";
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.email_txt.Location = new System.Drawing.Point(65, 259);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(111, 22);
            this.email_txt.TabIndex = 13;
            this.email_txt.Text = "Enter email :";
            this.email_txt.Click += new System.EventHandler(this.email_txt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(26, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 1);
            this.panel1.TabIndex = 15;
            // 
            // pss_txt
            // 
            this.pss_txt.AutoSize = true;
            this.pss_txt.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pss_txt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pss_txt.Location = new System.Drawing.Point(61, 339);
            this.pss_txt.Name = "pss_txt";
            this.pss_txt.Size = new System.Drawing.Size(144, 22);
            this.pss_txt.TabIndex = 16;
            this.pss_txt.Text = "Enter passward :";
            this.pss_txt.Click += new System.EventHandler(this.pss_txt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(26, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 1);
            this.panel2.TabIndex = 16;
            // 
            // user_email
            // 
            this.user_email.BackColor = System.Drawing.SystemColors.Control;
            this.user_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_email.Location = new System.Drawing.Point(65, 285);
            this.user_email.Multiline = true;
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(350, 44);
            this.user_email.TabIndex = 18;
            // 
            // user_pass
            // 
            this.user_pass.BackColor = System.Drawing.SystemColors.Control;
            this.user_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_pass.Location = new System.Drawing.Point(65, 364);
            this.user_pass.Multiline = true;
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(354, 44);
            this.user_pass.TabIndex = 19;
            this.user_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // admin_login
            // 
            this.admin_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.admin_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_login.Location = new System.Drawing.Point(22, 430);
            this.admin_login.Name = "admin_login";
            this.admin_login.Size = new System.Drawing.Size(393, 48);
            this.admin_login.TabIndex = 20;
            this.admin_login.Text = "LOG IN";
            this.admin_login.UseVisualStyleBackColor = false;
            this.admin_login.Click += new System.EventHandler(this.admin_login_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.Control;
            this.back_button.Location = new System.Drawing.Point(65, 498);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(138, 51);
            this.back_button.TabIndex = 21;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.RoyalBlue;
            this.Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.ForeColor = System.Drawing.SystemColors.Control;
            this.Signup.Location = new System.Drawing.Point(221, 498);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(138, 51);
            this.Signup.TabIndex = 22;
            this.Signup.Text = "SIGN UP";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 675);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.admin_login);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_email);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pss_txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "USER";
            this.Text = "USER";
            this.Load += new System.EventHandler(this.USER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pss_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.TextBox user_pass;
        private System.Windows.Forms.Button admin_login;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Signup;
    }
}