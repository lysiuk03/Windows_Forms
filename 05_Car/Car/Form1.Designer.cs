namespace Car
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Probig_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Volume_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Color_comboBox = new System.Windows.Forms.ComboBox();
            this.Year_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Model_textBox = new System.Windows.Forms.TextBox();
            this.Show_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Load_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Probig_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_numericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Probig_numericUpDown);
            this.panel1.Controls.Add(this.Volume_numericUpDown);
            this.panel1.Controls.Add(this.Color_comboBox);
            this.panel1.Controls.Add(this.Year_numericUpDown);
            this.panel1.Controls.Add(this.Model_textBox);
            this.panel1.Controls.Add(this.Show_button);
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.Add_button);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 426);
            this.panel1.TabIndex = 0;
            // 
            // Probig_numericUpDown
            // 
            this.Probig_numericUpDown.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Probig_numericUpDown.Location = new System.Drawing.Point(125, 186);
            this.Probig_numericUpDown.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.Probig_numericUpDown.Name = "Probig_numericUpDown";
            this.Probig_numericUpDown.Size = new System.Drawing.Size(227, 27);
            this.Probig_numericUpDown.TabIndex = 13;
            // 
            // Volume_numericUpDown
            // 
            this.Volume_numericUpDown.DecimalPlaces = 1;
            this.Volume_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Volume_numericUpDown.Location = new System.Drawing.Point(125, 236);
            this.Volume_numericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Volume_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Volume_numericUpDown.Name = "Volume_numericUpDown";
            this.Volume_numericUpDown.Size = new System.Drawing.Size(227, 27);
            this.Volume_numericUpDown.TabIndex = 12;
            this.Volume_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Color_comboBox
            // 
            this.Color_comboBox.FormattingEnabled = true;
            this.Color_comboBox.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Black",
            "White",
            "Silver",
            "Gold"});
            this.Color_comboBox.Location = new System.Drawing.Point(125, 136);
            this.Color_comboBox.Name = "Color_comboBox";
            this.Color_comboBox.Size = new System.Drawing.Size(227, 28);
            this.Color_comboBox.TabIndex = 11;
            // 
            // Year_numericUpDown
            // 
            this.Year_numericUpDown.Location = new System.Drawing.Point(125, 93);
            this.Year_numericUpDown.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.Year_numericUpDown.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.Year_numericUpDown.Name = "Year_numericUpDown";
            this.Year_numericUpDown.Size = new System.Drawing.Size(227, 27);
            this.Year_numericUpDown.TabIndex = 10;
            this.Year_numericUpDown.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // Model_textBox
            // 
            this.Model_textBox.Location = new System.Drawing.Point(125, 53);
            this.Model_textBox.Name = "Model_textBox";
            this.Model_textBox.Size = new System.Drawing.Size(227, 27);
            this.Model_textBox.TabIndex = 9;
            // 
            // Show_button
            // 
            this.Show_button.Location = new System.Drawing.Point(20, 384);
            this.Show_button.Name = "Show_button";
            this.Show_button.Size = new System.Drawing.Size(332, 29);
            this.Show_button.TabIndex = 8;
            this.Show_button.Text = "SHOW CAR";
            this.Show_button.UseVisualStyleBackColor = true;
            this.Show_button.Click += new System.EventHandler(this.Show_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(20, 349);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(332, 29);
            this.Delete_button.TabIndex = 7;
            this.Delete_button.Text = "DELETE SELECTED CAR";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(20, 314);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(332, 29);
            this.Add_button.TabIndex = 6;
            this.Add_button.Text = "ADD CAR";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Volume:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Probig:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW CAR";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Load_button);
            this.panel2.Controls.Add(this.Save_button);
            this.panel2.Controls.Add(this.listBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(391, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 426);
            this.panel2.TabIndex = 1;
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(212, 363);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(160, 50);
            this.Load_button.TabIndex = 8;
            this.Load_button.Text = "LOAD";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(32, 363);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(163, 50);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = "SAVE";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(19, 53);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(363, 304);
            this.listBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(122, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 38);
            this.label7.TabIndex = 1;
            this.label7.Text = "CAR LIST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Probig_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_numericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private NumericUpDown Probig_numericUpDown;
        private NumericUpDown Volume_numericUpDown;
        private ComboBox Color_comboBox;
        private NumericUpDown Year_numericUpDown;
        private TextBox Model_textBox;
        private Button Show_button;
        private Button Delete_button;
        private Button Add_button;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Load_button;
        private Button Save_button;
        private ListBox listBox;
        private Label label7;
    }
}