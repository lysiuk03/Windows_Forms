using System.Windows.Forms;

namespace Products_Editor
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateProducts()
        {
            products_listBox.DataSource = null;
            products_listBox.DataSource = products;
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            Form2 form = new Form2(p);
            if (form.ShowDialog() == DialogResult.OK)
            {
                products.Add(p);
                UpdateProducts();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (products_listBox.SelectedIndex == -1)
            {
                MessageBox.Show("No selected Item!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                products.RemoveAt(products_listBox.SelectedIndex);
                UpdateProducts();
            }
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            if (products_listBox.SelectedIndex == -1)
            {
                MessageBox.Show("No selected Item!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Form2 form = new Form2(products[products_listBox.SelectedIndex]);
                form.OnlyRead();

                form.ShowDialog();
                form.Edit();
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(products[products_listBox.SelectedIndex]);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateProducts();
            }
        }

        private void background_button_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
            }
        }

        private void font_button_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                var selected = font.Font;
                label1.Font = selected;
                edit_button.Font = selected;
                info_button.Font = selected;
                add_button.Font = selected;
                delete_button.Font = selected;
            }
        }

        private void font_prod_button_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                products_listBox.Font = font.Font;
            }
        }
    }
}