namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int max = 100;
            int min = 0;
            int count = 0;
            bool ok = true;
            while (ok)
            {
                count++;
                if (n == min + (max - min) / 2)
                {
                    MessageBox.Show($"Number:: {++n}\n Requests: {count}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ok = false;
                    break;
                }
                n = min + (max - min) / 2;
                if (MessageBox.Show($"Is your number greater then {n} ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    min = n;
                }
                else
                {
                    max = n;
                }
            }
        }
    }
}