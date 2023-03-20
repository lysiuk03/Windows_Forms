using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_explorer
{
    public partial class Form2 : Form
    {
        public string Name { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string name)
        {
            InitializeComponent();
            Name = name;
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_textBox.Text))
            {
                MessageBox.Show(" Enter file name!");
                return;
            }
            Name = name_textBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
