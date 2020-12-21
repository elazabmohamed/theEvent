namespace theEvent
{
    partial class AdminLog
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lPasswordAdmin = new System.Windows.Forms.Label();
            this.lEmailAdmin = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.logAdmin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lPasswordAdmin);
            this.panel4.Controls.Add(this.lEmailAdmin);
            this.panel4.Controls.Add(this.tbEmail);
            this.panel4.Controls.Add(this.logAdmin);
            this.panel4.Controls.Add(this.tbPassword);
            this.panel4.Location = new System.Drawing.Point(84, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 197);
            this.panel4.TabIndex = 15;
            // 
            // lPasswordAdmin
            // 
            this.lPasswordAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lPasswordAdmin.Font = new System.Drawing.Font("Coldiac Free", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasswordAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.lPasswordAdmin.Location = new System.Drawing.Point(20, 74);
            this.lPasswordAdmin.Name = "lPasswordAdmin";
            this.lPasswordAdmin.Size = new System.Drawing.Size(100, 23);
            this.lPasswordAdmin.TabIndex = 24;
            this.lPasswordAdmin.Text = "Password";
            // 
            // lEmailAdmin
            // 
            this.lEmailAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lEmailAdmin.Font = new System.Drawing.Font("Coldiac Free", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmailAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.lEmailAdmin.Location = new System.Drawing.Point(20, 7);
            this.lEmailAdmin.Name = "lEmailAdmin";
            this.lEmailAdmin.Size = new System.Drawing.Size(100, 23);
            this.lEmailAdmin.TabIndex = 23;
            this.lEmailAdmin.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Raleway", 10.8F);
            this.tbEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbEmail.Location = new System.Drawing.Point(23, 33);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(261, 28);
            this.tbEmail.TabIndex = 2;
            // 
            // logAdmin
            // 
            this.logAdmin.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.logAdmin.Location = new System.Drawing.Point(89, 144);
            this.logAdmin.Name = "logAdmin";
            this.logAdmin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.logAdmin.Size = new System.Drawing.Size(123, 37);
            this.logAdmin.TabIndex = 20;
            this.logAdmin.Values.Text = "Log in";
            this.logAdmin.Click += new System.EventHandler(this.logAdmin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(24, 100);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(261, 28);
            this.tbPassword.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Raleway", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.BurlyWood;
            this.label9.Location = new System.Drawing.Point(193, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "thEvent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(470, 310);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Name = "AdminLog";
            this.Text = "AdminLog";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lPasswordAdmin;
        private System.Windows.Forms.Label lEmailAdmin;
        private System.Windows.Forms.TextBox tbEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton logAdmin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label9;
    }
}