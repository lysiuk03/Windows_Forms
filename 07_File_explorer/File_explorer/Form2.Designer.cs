namespace File_explorer
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
            name_textBox = new TextBox();
            label1 = new Label();
            cancel_button = new Button();
            ok_button = new Button();
            SuspendLayout();
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(30, 74);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(239, 27);
            name_textBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(248, 36);
            label1.TabIndex = 1;
            label1.Text = "Enter file name";
            // 
            // cancel_button
            // 
            cancel_button.BackColor = Color.IndianRed;
            cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_button.Location = new Point(30, 117);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(100, 40);
            cancel_button.TabIndex = 2;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // ok_button
            // 
            ok_button.BackColor = Color.LimeGreen;
            ok_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ok_button.Location = new Point(169, 117);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(100, 40);
            ok_button.TabIndex = 3;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = false;
            ok_button.Click += ok_button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 169);
            Controls.Add(ok_button);
            Controls.Add(cancel_button);
            Controls.Add(label1);
            Controls.Add(name_textBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_textBox;
        private Label label1;
        private Button cancel_button;
        private Button ok_button;
    }
}