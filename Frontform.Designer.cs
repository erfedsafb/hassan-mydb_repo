namespace Database_project
{
    partial class Frontform
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
            this.admin_button = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_button
            // 
            this.admin_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.admin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_button.Location = new System.Drawing.Point(221, 126);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(162, 70);
            this.admin_button.TabIndex = 0;
            this.admin_button.Text = "ADMIN";
            this.admin_button.UseVisualStyleBackColor = false;
            this.admin_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_button
            // 
            this.user_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.user_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_button.Location = new System.Drawing.Point(221, 226);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(162, 70);
            this.user_button.TabIndex = 1;
            this.user_button.Text = "USER";
            this.user_button.UseVisualStyleBackColor = false;
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcom to Event Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(30, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Powered by :HFAM";
            // 
            // Frontform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(626, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_button);
            this.Controls.Add(this.admin_button);
            this.Name = "Frontform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frontform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

