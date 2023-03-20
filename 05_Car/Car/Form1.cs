using System.Runtime.Serialization.Formatters.Binary;

namespace Car
{
    public partial class Form1 : Form
    {
        List<Cars> cars = new List<Cars>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            if(Model_textBox.Text == "" || Color_comboBox.Text=="" || (int)Probig_numericUpDown.Value==0)
            {
                MessageBox.Show(" Fill in all fields!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cars.Add(new Cars(Model_textBox.Text, (int)Year_numericUpDown.Value, Color_comboBox.Text, (int)Probig_numericUpDown.Value, (double)Volume_numericUpDown.Value));
                UpdateCars();
            }
        }
        private void UpdateCars()
        {
           listBox.DataSource = null;
           listBox.DataSource = cars;
        }
        private void Show_button_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("No selected Item!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show(cars[listBox.SelectedIndex].AllInfo());
            }
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("No selected Item!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            { 
                cars.RemoveAt(listBox.SelectedIndex);
                UpdateCars();
            }
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream fstream = File.Create("Cars.bin"))
            {
                binaryFormatter.Serialize(fstream, cars);
            }
        }
        private void Load_button_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            cars = null;
            using (Stream fstream = File.OpenRead("Cars.bin"))
            {
                cars=(List<Cars>)binaryFormatter.Deserialize(fstream);
                UpdateCars();
            }
        }
    }
}