namespace theEvent
{
    partial class UpdatePersonInfo
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
            this.LogLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbCity = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUpdatingEm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity)).BeginInit();
            this.SuspendLayout();
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.LogLabel.Location = new System.Drawing.Point(437, 0);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(113, 20);
            this.LogLabel.TabIndex = 76;
            this.LogLabel.Text = "LOG LABEL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.BurlyWood;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 91);
            this.label9.TabIndex = 75;
            this.label9.Text = "thEvent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 553);
            this.dateTimePicker1.MaxDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1899, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker1.TabIndex = 87;
            this.dateTimePicker1.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(169, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 86;
            this.label5.Text = "Birth Date";
            // 
            // BUpdate
            // 
            this.BUpdate.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.BUpdate.Location = new System.Drawing.Point(244, 626);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.BUpdate.Size = new System.Drawing.Size(123, 37);
            this.BUpdate.TabIndex = 85;
            this.BUpdate.Values.Text = "Update";
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // cbCity
            // 
            this.cbCity.DropDownWidth = 261;
            this.cbCity.Location = new System.Drawing.Point(172, 470);
            this.cbCity.Name = "cbCity";
            this.cbCity.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.cbCity.Size = new System.Drawing.Size(261, 25);
            this.cbCity.TabIndex = 84;
            this.cbCity.Text = "select your city";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(169, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 83;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(169, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 82;
            this.label3.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(169, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 81;
            this.label1.Text = "Password";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(169, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 80;
            this.label6.Text = "First Name";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Footlight MT Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPassword.Location = new System.Drawing.Point(172, 393);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(261, 27);
            this.tbPassword.TabIndex = 79;
            // 
            // tbLName
            // 
            this.tbLName.BackColor = System.Drawing.Color.White;
            this.tbLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLName.Font = new System.Drawing.Font("Footlight MT Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbLName.Location = new System.Drawing.Point(172, 318);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(261, 27);
            this.tbLName.TabIndex = 78;
            // 
            // tbFName
            // 
            this.tbFName.BackColor = System.Drawing.Color.White;
            this.tbFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFName.Font = new System.Drawing.Font("Footlight MT Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbFName.Location = new System.Drawing.Point(172, 246);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(261, 27);
            this.tbFName.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(169, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 88;
            this.label2.Text = "UPDATING:";
            // 
            // tbUpdatingEm
            // 
            this.tbUpdatingEm.AutoSize = true;
            this.tbUpdatingEm.BackColor = System.Drawing.Color.Transparent;
            this.tbUpdatingEm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdatingEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.tbUpdatingEm.Location = new System.Drawing.Point(245, 150);
            this.tbUpdatingEm.Name = "tbUpdatingEm";
            this.tbUpdatingEm.Size = new System.Drawing.Size(22, 19);
            this.tbUpdatingEm.TabIndex = 89;
            this.tbUpdatingEm.Text = "@";
            // 
            // UpdatePersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(550, 679);
            this.Controls.Add(this.tbUpdatingEm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.label9);
            this.Name = "UpdatePersonInfo";
            this.Text = "UpdatePersonInfo";
            this.Load += new System.EventHandler(this.UpdatePersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbUpdatingEm;
    }
}