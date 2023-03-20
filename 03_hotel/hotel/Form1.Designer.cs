namespace hotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.surname_lab = new System.Windows.Forms.Label();
            this.name_lab = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_hotel = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.maskedTextBox_phone = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown_count = new System.Windows.Forms.NumericUpDown();
            this.label_peoplecount = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox_typeroom = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.label_comm = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).BeginInit();
            this.groupBox_typeroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // surname_lab
            // 
            this.surname_lab.AutoSize = true;
            this.surname_lab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surname_lab.Location = new System.Drawing.Point(12, 92);
            this.surname_lab.Name = "surname_lab";
            this.surname_lab.Size = new System.Drawing.Size(86, 25);
            this.surname_lab.TabIndex = 0;
            this.surname_lab.Text = "Surname:";
            // 
            // name_lab
            // 
            this.name_lab.AutoSize = true;
            this.name_lab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_lab.Location = new System.Drawing.Point(12, 59);
            this.name_lab.Name = "name_lab";
            this.name_lab.Size = new System.Drawing.Size(63, 25);
            this.name_lab.TabIndex = 1;
            this.name_lab.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(159, 60);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(176, 27);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(159, 93);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(176, 27);
            this.textBox_surname.TabIndex = 3;
            // 
            // label_hotel
            // 
            this.label_hotel.AutoSize = true;
            this.label_hotel.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hotel.Location = new System.Drawing.Point(384, 21);
            this.label_hotel.Name = "label_hotel";
            this.label_hotel.Size = new System.Drawing.Size(150, 50);
            this.label_hotel.TabIndex = 4;
            this.label_hotel.Text = "Hotel";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_phone.Location = new System.Drawing.Point(12, 125);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(133, 25);
            this.label_phone.TabIndex = 5;
            this.label_phone.Text = "Phone number:";
            // 
            // maskedTextBox_phone
            // 
            this.maskedTextBox_phone.Location = new System.Drawing.Point(159, 126);
            this.maskedTextBox_phone.Mask = "+(380) 00-000-00-00";
            this.maskedTextBox_phone.Name = "maskedTextBox_phone";
            this.maskedTextBox_phone.Size = new System.Drawing.Size(176, 27);
            this.maskedTextBox_phone.TabIndex = 6;
            // 
            // numericUpDown_count
            // 
            this.numericUpDown_count.Location = new System.Drawing.Point(159, 159);
            this.numericUpDown_count.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_count.Name = "numericUpDown_count";
            this.numericUpDown_count.Size = new System.Drawing.Size(176, 27);
            this.numericUpDown_count.TabIndex = 7;
            this.numericUpDown_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_peoplecount
            // 
            this.label_peoplecount.AutoSize = true;
            this.label_peoplecount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_peoplecount.Location = new System.Drawing.Point(12, 157);
            this.label_peoplecount.Name = "label_peoplecount";
            this.label_peoplecount.Size = new System.Drawing.Size(119, 25);
            this.label_peoplecount.TabIndex = 8;
            this.label_peoplecount.Text = "People count:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Econom";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Standart";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 86);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 24);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Luxe";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox_typeroom
            // 
            this.groupBox_typeroom.Controls.Add(this.radioButton1);
            this.groupBox_typeroom.Controls.Add(this.radioButton3);
            this.groupBox_typeroom.Controls.Add(this.radioButton2);
            this.groupBox_typeroom.Location = new System.Drawing.Point(394, 90);
            this.groupBox_typeroom.Name = "groupBox_typeroom";
            this.groupBox_typeroom.Size = new System.Drawing.Size(151, 118);
            this.groupBox_typeroom.TabIndex = 12;
            this.groupBox_typeroom.TabStop = false;
            this.groupBox_typeroom.Text = "Room type:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(590, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 13;
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(159, 192);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_comment.Size = new System.Drawing.Size(176, 86);
            this.textBox_comment.TabIndex = 14;
            // 
            // label_comm
            // 
            this.label_comm.AutoSize = true;
            this.label_comm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_comm.Location = new System.Drawing.Point(12, 191);
            this.label_comm.Name = "label_comm";
            this.label_comm.Size = new System.Drawing.Size(95, 25);
            this.label_comm.TabIndex = 15;
            this.label_comm.Text = "Comment:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(228, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "General terms and conditions;";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(33, 356);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(261, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Rights, rules of conduct during use;";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox2_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Accept the terms of use:";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.ForestGreen;
            this.button_save.Enabled = false;
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_save.FlatAppearance.BorderSize = 4;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(395, 326);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 69);
            this.button_save.TabIndex = 19;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(618, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 69);
            this.button2.TabIndex = 20;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(477, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 39);
            this.button4.TabIndex = 22;
            this.button4.Text = "Read from file";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_comm);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox_typeroom);
            this.Controls.Add(this.label_peoplecount);
            this.Controls.Add(this.numericUpDown_count);
            this.Controls.Add(this.maskedTextBox_phone);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_hotel);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.name_lab);
            this.Controls.Add(this.surname_lab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).EndInit();
            this.groupBox_typeroom.ResumeLayout(false);
            this.groupBox_typeroom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label surname_lab;
        private Label name_lab;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private Label label_hotel;
        private Label label_phone;
        private MaskedTextBox maskedTextBox_phone;
        private NumericUpDown numericUpDown_count;
        private Label label_peoplecount;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox_typeroom;
        private MonthCalendar monthCalendar1;
        private TextBox textBox_comment;
        private Label label_comm;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Button button_save;
        private Button button2;
        private Button button4;
    }
}