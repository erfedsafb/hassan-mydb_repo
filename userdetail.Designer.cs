namespace Database_project
{
    partial class userdetail
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
            this.email_txt = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.passward = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.email_txt.Location = new System.Drawing.Point(322, 46);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(111, 22);
            this.email_txt.TabIndex = 14;
            this.email_txt.Text = "Enter name :";
            this.email_txt.Click += new System.EventHandler(this.email_txt_Click);
            // 
            // first_name
            // 
            this.first_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.Location = new System.Drawing.Point(277, 129);
            this.first_name.Multiline = true;
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(350, 31);
            this.first_name.TabIndex = 19;
            this.first_name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Create Your  Account and Dive into Event Planning";
            // 
            // admin_button
            // 
            this.admin_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.admin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_button.Location = new System.Drawing.Point(74, 397);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(133, 57);
            this.admin_button.TabIndex = 23;
            this.admin_button.Text = "SAVE";
            this.admin_button.UseVisualStyleBackColor = false;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(576, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 24;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(26, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Enter first name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(26, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Enter passward :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(26, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Enter email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(26, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Enter last name:";
            // 
            // last_name
            // 
            this.last_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.last_name.Location = new System.Drawing.Point(277, 182);
            this.last_name.Multiline = true;
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(350, 31);
            this.last_name.TabIndex = 33;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(277, 235);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(350, 31);
            this.email.TabIndex = 34;
            // 
            // passward
            // 
            this.passward.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passward.Location = new System.Drawing.Point(277, 289);
            this.passward.Multiline = true;
            this.passward.Name = "passward";
            this.passward.Size = new System.Drawing.Size(350, 31);
            this.passward.TabIndex = 35;
            // 
            // userdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.passward);
            this.Controls.Add(this.email);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.email_txt);
            this.Name = "userdetail";
            this.Text = "userdetail";
            this.Load += new System.EventHandler(this.userdetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox passward;
    }
}