namespace Products_Editor
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
            products_listBox = new ListBox();
            label1 = new Label();
            edit_button = new Button();
            info_button = new Button();
            add_button = new Button();
            delete_button = new Button();
            background_button = new Button();
            font_button = new Button();
            font_prod_button = new Button();
            SuspendLayout();
            // 
            // products_listBox
            // 
            products_listBox.FormattingEnabled = true;
            products_listBox.ItemHeight = 20;
            products_listBox.Location = new Point(12, 63);
            products_listBox.Name = "products_listBox";
            products_listBox.Size = new Size(430, 304);
            products_listBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 49);
            label1.TabIndex = 1;
            label1.Text = "Products";
            // 
            // edit_button
            // 
            edit_button.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            edit_button.Location = new Point(12, 392);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(103, 46);
            edit_button.TabIndex = 2;
            edit_button.Text = "Edit";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += edit_button_Click;
            // 
            // info_button
            // 
            info_button.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            info_button.Location = new Point(121, 392);
            info_button.Name = "info_button";
            info_button.Size = new Size(103, 46);
            info_button.TabIndex = 3;
            info_button.Text = "Info";
            info_button.UseVisualStyleBackColor = true;
            info_button.Click += info_button_Click;
            // 
            // add_button
            // 
            add_button.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            add_button.Location = new Point(230, 392);
            add_button.Name = "add_button";
            add_button.Size = new Size(103, 46);
            add_button.TabIndex = 4;
            add_button.Text = "+";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // delete_button
            // 
            delete_button.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            delete_button.Location = new Point(339, 392);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(103, 46);
            delete_button.TabIndex = 5;
            delete_button.Text = "-";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // background_button
            // 
            background_button.Location = new Point(448, 184);
            background_button.Name = "background_button";
            background_button.Size = new Size(137, 124);
            background_button.TabIndex = 6;
            background_button.Text = "Background color";
            background_button.UseVisualStyleBackColor = true;
            background_button.Click += background_button_Click;
            // 
            // font_button
            // 
            font_button.Location = new Point(448, 314);
            font_button.Name = "font_button";
            font_button.Size = new Size(137, 124);
            font_button.TabIndex = 7;
            font_button.Text = "Font";
            font_button.UseVisualStyleBackColor = true;
            font_button.Click += font_button_Click;
            // 
            // font_prod_button
            // 
            font_prod_button.Location = new Point(448, 63);
            font_prod_button.Name = "font_prod_button";
            font_prod_button.Size = new Size(137, 115);
            font_prod_button.TabIndex = 8;
            font_prod_button.Text = "Font Products";
            font_prod_button.UseVisualStyleBackColor = true;
            font_prod_button.Click += font_prod_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 450);
            Controls.Add(font_prod_button);
            Controls.Add(font_button);
            Controls.Add(background_button);
            Controls.Add(delete_button);
            Controls.Add(add_button);
            Controls.Add(info_button);
            Controls.Add(edit_button);
            Controls.Add(label1);
            Controls.Add(products_listBox);
            Name = "Form1";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox products_listBox;
        private Label label1;
        private Button edit_button;
        private Button info_button;
        private Button add_button;
        private Button delete_button;
        private Button background_button;
        private Button font_button;
        private Button font_prod_button;
    }
}