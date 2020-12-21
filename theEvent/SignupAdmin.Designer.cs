namespace theEvent
{
    partial class SignupAdmin
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BSignup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbCity = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(72, 580);
            this.dateTimePicker2.MaxDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1899, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker2.TabIndex = 49;
            this.dateTimePicker2.Value = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(69, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Birth Date";
            // 
            // BSignup
            // 
            this.BSignup.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.BSignup.Location = new System.Drawing.Point(125, 650);
            this.BSignup.Name = "BSignup";
            this.BSignup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.BSignup.Size = new System.Drawing.Size(148, 37);
            this.BSignup.TabIndex = 47;
            this.BSignup.Values.Text = "Sign Up an Admin";
            this.BSignup.Click += new System.EventHandler(this.BSignup_Click);
            // 
            // cbCity
            // 
            this.cbCity.DropDownWidth = 261;
            this.cbCity.Location = new System.Drawing.Point(72, 509);
            this.cbCity.Name = "cbCity";
            this.cbCity.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.cbCity.Size = new System.Drawing.Size(261, 25);
            this.cbCity.TabIndex = 45;
            this.cbCity.Text = "select your city";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(69, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(69, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(69, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(69, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Password";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(69, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "First Name";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Footlight MT Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPassword.Location = new System.Drawing.Point(72, 432);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(261, 27);
            this.tbPassword.TabIndex = 39;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Footlight MT Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbEmail.Location = new System.Drawing.Point(72, 358);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(261, 27);
            this.tbEmail.TabIndex = 38;
            // 
            // tbLName
            // 
            this.tbLName.BackColor = System.Drawing.Color.White;
            this.tbLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLName.Font = new System.Drawing.Font("Footlight MT Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbLName.Location = new System.Drawing.Point(72, 282);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(261, 27);
            this.tbLName.TabIndex = 37;
            // 
            // tbFName
            // 
            this.tbFName.BackColor = System.Drawing.Color.White;
            this.tbFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFName.Font = new System.Drawing.Font("Footlight MT Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbFName.Location = new System.Drawing.Point(72, 210);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(261, 27);
            this.tbFName.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.BurlyWood;
            this.label9.Location = new System.Drawing.Point(56, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 91);
            this.label9.TabIndex = 50;
            this.label9.Text = "thEvent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SignupAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(417, 718);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BSignup);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbFName);
            this.Name = "SignupAdmin";
            this.Text = "SignupAdmin";
            this.Load += new System.EventHandler(this.SignupAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BSignup;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label label9;
    }
}