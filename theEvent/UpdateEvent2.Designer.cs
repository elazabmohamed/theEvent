namespace theEvent
{
    partial class UpdateEvent2
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
            this.label9 = new System.Windows.Forms.Label();
            this.LogLabel2 = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbCity = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BUpdateEvent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.eventIDHolder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.BurlyWood;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 91);
            this.label9.TabIndex = 63;
            this.label9.Text = "thEvent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogLabel2
            // 
            this.LogLabel2.AutoSize = true;
            this.LogLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LogLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.LogLabel2.Location = new System.Drawing.Point(781, 0);
            this.LogLabel2.Name = "LogLabel2";
            this.LogLabel2.Size = new System.Drawing.Size(113, 20);
            this.LogLabel2.TabIndex = 62;
            this.LogLabel2.Text = "LOG LABEL";
            // 
            // EventName
            // 
            this.EventName.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.EventName.Location = new System.Drawing.Point(127, 246);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(293, 28);
            this.EventName.TabIndex = 61;
            this.EventName.TextChanged += new System.EventHandler(this.EventName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(94, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "What is the Name of your Event?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(490, 294);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 12, 15, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker1.TabIndex = 59;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 15, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbCity
            // 
            this.cbCity.DropDownWidth = 293;
            this.cbCity.Location = new System.Drawing.Point(127, 291);
            this.cbCity.Name = "cbCity";
            this.cbCity.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.cbCity.Size = new System.Drawing.Size(293, 25);
            this.cbCity.TabIndex = 58;
            this.cbCity.Text = "Where?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(443, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Add your notes, specific adress, ect";
            // 
            // tbNote
            // 
            this.tbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.tbNote.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.tbNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.tbNote.Location = new System.Drawing.Point(490, 387);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(293, 236);
            this.tbNote.TabIndex = 56;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.checkedListBox1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(127, 387);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(261, 234);
            this.checkedListBox1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(94, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Whom Do You Want to Invite?";
            // 
            // cbType
            // 
            this.cbType.DropDownWidth = 261;
            this.cbType.Items.AddRange(new object[] {
            "Sport",
            "Musical",
            "Social"});
            this.cbType.Location = new System.Drawing.Point(490, 246);
            this.cbType.Name = "cbType";
            this.cbType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.cbType.Size = new System.Drawing.Size(293, 25);
            this.cbType.TabIndex = 53;
            this.cbType.Text = "what kind of event is it?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(75, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 36);
            this.label6.TabIndex = 52;
            this.label6.Text = "Update Your Event.";
            // 
            // BUpdateEvent
            // 
            this.BUpdateEvent.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.BUpdateEvent.Location = new System.Drawing.Point(385, 653);
            this.BUpdateEvent.Name = "BUpdateEvent";
            this.BUpdateEvent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.BUpdateEvent.Size = new System.Drawing.Size(123, 37);
            this.BUpdateEvent.TabIndex = 64;
            this.BUpdateEvent.Values.Text = "Update";
            this.BUpdateEvent.Click += new System.EventHandler(this.BAddEvent_Click);
            // 
            // eventIDHolder
            // 
            this.eventIDHolder.AutoSize = true;
            this.eventIDHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIDHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.eventIDHolder.Location = new System.Drawing.Point(716, 173);
            this.eventIDHolder.Name = "eventIDHolder";
            this.eventIDHolder.Size = new System.Drawing.Size(92, 24);
            this.eventIDHolder.TabIndex = 65;
            this.eventIDHolder.Text = "EVENTID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(618, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 66;
            this.label4.Text = "Event ID:";
            // 
            // UpdateEvent2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(894, 702);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventIDHolder);
            this.Controls.Add(this.BUpdateEvent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LogLabel2);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label6);
            this.Name = "UpdateEvent2";
            this.Text = "UpdateEvent2";
            this.Load += new System.EventHandler(this.UpdateEvent2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LogLabel2;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbType;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BUpdateEvent;
        private System.Windows.Forms.Label eventIDHolder;
        private System.Windows.Forms.Label label4;
    }
}