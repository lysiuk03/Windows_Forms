using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Products_Editor
{
    public partial class Form2 : Form
    {
        public Product Prod { get; set; }


        public Form2()
        {
            InitializeComponent();
            Prod = new Product();
        }
        public Form2(Product prod)
        {
            InitializeComponent();
            Prod = prod;
            if(prod != null )
            {
                name_textBox.Text = prod.Name;
                price_numericUpDown.Value = prod.Price;
                country_comboBox.Text = prod.Country;
                quantity_numericUpDown.Value = prod.Quantity;
                discount_numericUpDown.Value = prod.Discount;
            }
        }
        public void OnlyRead()
        {
            name_textBox.Enabled= false;
            price_numericUpDown.Enabled= false;
            country_comboBox.Enabled= false;
            quantity_numericUpDown.Enabled= false;
            discount_numericUpDown.Enabled= false;
            cancel_button.Enabled= false;
        }
        public void Edit()
        {
            name_textBox.Enabled = true;
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_textBox.Text) || string.IsNullOrWhiteSpace(country_comboBox.Text) ||
                quantity_numericUpDown.Value == 0 ||  price_numericUpDown.Value == 0)
            {
                MessageBox.Show(" Enter all INFO!");
                return;
            }
            Prod.Name = name_textBox.Text;
            Prod.Price = (int)price_numericUpDown.Value;
            Prod.Country = country_comboBox.Text;
            Prod.Quantity = (int)quantity_numericUpDown.Value;
            Prod.Discount = (int)discount_numericUpDown.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
