namespace Notepad_Plus_Plus
{
    public partial class Form1 : Form
    {
        int size;
        public Form1()
        {
            InitializeComponent();
            size = 9;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 0)
            {
                textBox1.ReadOnly = false;
                textBox1.MaxLength = (int)numericUpDown1.Value;
                toolStripStatusLabel1.Text = $"0/{(int)numericUpDown1.Value}";
                toolStripProgressBar1.Maximum= (int)numericUpDown1.Value;
            }
            else
            {
                textBox1.ReadOnly = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string[] words=text.Split(' ',System.StringSplitOptions.RemoveEmptyEntries);
            int symbols = 0, numbers = 0, letters = 0;
            symbols = text.Length;
            toolStripStatusLabel1.Text = $"{symbols}/{(int)numericUpDown1.Value}";
            toolStripProgressBar1.Value = symbols;
            for (int i = 0; i < text.Length; i++)
            {
                if(Char.IsLetter(text[i]))
                {
                    letters++;
                    toolStripStatusLabel3.Text = $"Letters: {letters}";
                   
                }
                if(Char.IsNumber(text[i]))
                {
                    numbers++;
                    toolStripStatusLabel2.Text = $"Number: {numbers}";
                }
            }
            toolStripStatusLabel4.Text = $"Words: {words.Length}";
            if (text.Length ==0)
            {
                toolStripStatusLabel3.Text = $"Letters: 0";
                toolStripStatusLabel2.Text = $"Number: 0";
            }
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            textBox1.Font = new Font("Segoe UI", ++size, FontStyle.Regular);
        }

        private void fontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Segoe UI", --size, FontStyle.Regular);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Orange;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void violetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Violet;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap=true;
        }

        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}" + @"\note.txt"))
            {
                sw.WriteLine(textBox1.Text);
            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}" + @"\note.txt"))
            {
               textBox1.Text = sr.ReadLine();
            }
        }
    }
}