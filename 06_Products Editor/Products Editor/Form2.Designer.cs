namespace Products_Editor
{
    partial class Form2
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
            label1 = new Label();
            cancel_button = new Button();
            ok_button = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            name_textBox = new TextBox();
            price_numericUpDown = new NumericUpDown();
            country_comboBox = new ComboBox();
            quantity_numericUpDown = new NumericUpDown();
            discount_numericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)price_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantity_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discount_numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Engravers MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 47);
            label1.TabIndex = 0;
            label1.Text = "INFO";
            // 
            // cancel_button
            // 
            cancel_button.BackColor = Color.LightCoral;
            cancel_button.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_button.Location = new Point(12, 388);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(187, 50);
            cancel_button.TabIndex = 1;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // ok_button
            // 
            ok_button.BackColor = Color.MediumAquamarine;
            ok_button.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ok_button.Location = new Point(214, 388);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(187, 50);
            ok_button.TabIndex = 2;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = false;
            ok_button.Click += ok_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 94);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 146);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 197);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 5;
            label4.Text = "Country:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 253);
            label5.Name = "label5";
            label5.Size = new Size(138, 28);
            label5.TabIndex = 6;
            label5.Text = "Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 305);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 7;
            label6.Text = "Discount:";
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_textBox.Location = new Point(181, 91);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(206, 34);
            name_textBox.TabIndex = 8;
            // 
            // price_numericUpDown
            // 
            price_numericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price_numericUpDown.Location = new Point(181, 144);
            price_numericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            price_numericUpDown.Name = "price_numericUpDown";
            price_numericUpDown.Size = new Size(206, 34);
            price_numericUpDown.TabIndex = 9;
            // 
            // country_comboBox
            // 
            country_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            country_comboBox.FormattingEnabled = true;
            country_comboBox.Items.AddRange(new object[] { "Ukraine", "Denmark", "England", "Canada", "Germany", "France", "Spain" });
            country_comboBox.Location = new Point(181, 194);
            country_comboBox.Name = "country_comboBox";
            country_comboBox.Size = new Size(206, 36);
            country_comboBox.TabIndex = 10;
            // 
            // quantity_numericUpDown
            // 
            quantity_numericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quantity_numericUpDown.Location = new Point(181, 251);
            quantity_numericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            quantity_numericUpDown.Name = "quantity_numericUpDown";
            quantity_numericUpDown.Size = new Size(206, 34);
            quantity_numericUpDown.TabIndex = 11;
            // 
            // discount_numericUpDown
            // 
            discount_numericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            discount_numericUpDown.Location = new Point(181, 303);
            discount_numericUpDown.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            discount_numericUpDown.Name = "discount_numericUpDown";
            discount_numericUpDown.Size = new Size(206, 34);
            discount_numericUpDown.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(discount_numericUpDown);
            Controls.Add(quantity_numericUpDown);
            Controls.Add(country_comboBox);
            Controls.Add(price_numericUpDown);
            Controls.Add(name_textBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ok_button);
            Controls.Add(cancel_button);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Product Form";
            ((System.ComponentModel.ISupportInitialize)price_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantity_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)discount_numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cancel_button;
        private Button ok_button;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox name_textBox;
        private NumericUpDown price_numericUpDown;
        private ComboBox country_comboBox;
        private NumericUpDown quantity_numericUpDown;
        private NumericUpDown discount_numericUpDown;
    }
}