namespace theEvent
{
    partial class AddEvent
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BAddEvent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCity = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.TextBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.LogLabel2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(36, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Add Your Event.";
            // 
            // cbType
            // 
            this.cbType.DropDownWidth = 261;
            this.cbType.Items.AddRange(new object[] {
            "Sport",
            "Musical",
            "Social"});
            this.cbType.Location = new System.Drawing.Point(451, 207);
            this.cbType.Name = "cbType";
            this.cbType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.cbType.Size = new System.Drawing.Size(293, 25);
            this.cbType.TabIndex = 30;
            this.cbType.Text = "what kind of event is it?";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(55, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Whom Do You Want to Invite?";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.checkedListBox1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(88, 348);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(293, 257);
            this.checkedListBox1.TabIndex = 34;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // BAddEvent
            // 
            this.BAddEvent.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.BAddEvent.Location = new System.Drawing.Point(342, 607);
            this.BAddEvent.Name = "BAddEvent";
            this.BAddEvent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.BAddEvent.Size = new System.Drawing.Size(123, 37);
            this.BAddEvent.TabIndex = 35;
            this.BAddEvent.Values.Text = "Add";
            this.BAddEvent.Click += new System.EventHandler(this.BAddEvent_Click);
            // 
            // tbNote
            // 
            this.tbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.tbNote.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.tbNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.tbNote.Location = new System.Drawing.Point(451, 348);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(293, 237);
            this.tbNote.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(404, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Add your notes, specific adress, ect";
            // 
            // cbCity
            // 
            this.cbCity.DropDownWidth = 293;
            this.cbCity.Location = new System.Drawing.Point(88, 252);
            this.cbCity.Name = "cbCity";
            this.cbCity.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.cbCity.Size = new System.Drawing.Size(293, 25);
            this.cbCity.TabIndex = 39;
            this.cbCity.Text = "Where?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(451, 255);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 7, 17, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker1.TabIndex = 40;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 11, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(55, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "What is the Name of your Event?";
            // 
            // EventName
            // 
            this.EventName.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.EventName.Location = new System.Drawing.Point(88, 207);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(293, 28);
            this.EventName.TabIndex = 42;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // LogLabel2
            // 
            this.LogLabel2.AutoSize = true;
            this.LogLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LogLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.LogLabel2.Location = new System.Drawing.Point(723, 0);
            this.LogLabel2.Name = "LogLabel2";
            this.LogLabel2.Size = new System.Drawing.Size(113, 20);
            this.LogLabel2.TabIndex = 43;
            this.LogLabel2.Text = "LOG LABEL";
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
            this.label9.TabIndex = 51;
            this.label9.Text = "thEvent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(836, 666);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LogLabel2);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.BAddEvent);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label6);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BAddEvent;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EventName;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Label LogLabel2;
        private System.Windows.Forms.Label label9;
    }
}