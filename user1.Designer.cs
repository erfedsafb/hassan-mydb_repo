namespace Database_project
{
    partial class user1
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
            this.eventcreate_button = new System.Windows.Forms.Button();
            this.addparticipants_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventcreate_button
            // 
            this.eventcreate_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.eventcreate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventcreate_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eventcreate_button.Location = new System.Drawing.Point(229, 157);
            this.eventcreate_button.Name = "eventcreate_button";
            this.eventcreate_button.Size = new System.Drawing.Size(164, 70);
            this.eventcreate_button.TabIndex = 1;
            this.eventcreate_button.Text = "Create event";
            this.eventcreate_button.UseVisualStyleBackColor = false;
            this.eventcreate_button.Click += new System.EventHandler(this.eventcreate_button_Click);
            // 
            // addparticipants_button
            // 
            this.addparticipants_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addparticipants_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addparticipants_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addparticipants_button.Location = new System.Drawing.Point(27, 157);
            this.addparticipants_button.Name = "addparticipants_button";
            this.addparticipants_button.Size = new System.Drawing.Size(164, 70);
            this.addparticipants_button.TabIndex = 2;
            this.addparticipants_button.Text = "Add participants";
            this.addparticipants_button.UseVisualStyleBackColor = false;
            this.addparticipants_button.Click += new System.EventHandler(this.addparticipants_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(229, 295);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(164, 70);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(436, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "FEEDBACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 114);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(189, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "WELCOME USER";
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.addparticipants_button);
            this.Controls.Add(this.eventcreate_button);
            this.Name = "user1";
            this.Text = "user1";
            this.Load += new System.EventHandler(this.user1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eventcreate_button;
        private System.Windows.Forms.Button addparticipants_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}