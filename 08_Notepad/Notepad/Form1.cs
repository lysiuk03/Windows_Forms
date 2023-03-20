namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Clear();
        }

        public RichTextBox GetSelectedTb()
        {
            foreach (var item in tabControl1.SelectedTab.Controls.OfType<RichTextBox>())
            {
                if (item.Name == "richTextBox1")
                {
                    return item;
                }
            }
            return null;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = GetSelectedTb().Text;
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', ':', ';', '!', '?', '\n', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);
            int symbols = 0, numbers = 0, letters = 0;
            symbols = text.Length;
            length_toolStripStatusLabel.Text = $"Length: {symbols}";
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    letters++;
                    letters_toolStripStatusLabel.Text = $"Letters: {letters}";

                }
                if (Char.IsNumber(text[i]))
                {
                    numbers++;
                    numbers_toolStripStatusLabel.Text = $"Numbers: {numbers}";
                }
            }
            words_toolStripStatusLabel.Text = $"Words: {words.Length}";
            if (text.Length == 0)
            {
                letters_toolStripStatusLabel.Text = $"Letters: 0";
                numbers_toolStripStatusLabel.Text = $"Numbers: 0";
            }

            int lines = GetSelectedTb().Lines.Length;
            lines_toolStripStatusLabel.Text = $"Lines: {lines}";

            int currentline = GetSelectedTb().GetLineFromCharIndex(GetSelectedTb().GetFirstCharIndexOfCurrentLine());
            ln_toolStripStatusLabel.Text = $"Ln: {currentline + 1}";

            int firstChar = GetSelectedTb().GetFirstCharIndexFromLine(currentline);
            int column = GetSelectedTb().SelectionStart - firstChar;
            col_toolStripStatusLabel.Text = $"Col: {column + 1}";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage($"New {tabControl1.TabPages.Count + 1}");
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTextBox1.Size = new Size(1037, 557);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            tabPage.Controls.Add(richTextBox1);
            tabControl1.TabPages.Add(tabPage);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Want to create a new page?  (if you choose \"no\", the file will be opened in the selected)", "Open!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (result == DialogResult.Yes)
            {
                newToolStripMenuItem_Click(sender, e);
                tabControl1.SelectTab(tabControl1.TabCount - 1);
            }
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = "*.rtf";
            open.Filter = "RTF Files|*.rtf";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK && open.FileName.Length > 0)
            {
                GetSelectedTb().LoadFile(open.FileName);
                tabControl1.SelectedTab.Text = Path.GetFileName(open.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.rtf";
            save.Filter = "RTF Files|*.rtf";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                tabControl1.SelectedTab.Text = Path.GetFileName(save.FileName);
                GetSelectedTb().SaveFile(save.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.rtf";
            save.Filter = "RTF Files|*.rtf|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                tabControl1.SelectedTab.Text = Path.GetFileName(save.FileName);
                GetSelectedTb().SaveFile(save.FileName);
            }
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                tabControl1.SelectTab(i);
                saveToolStripMenuItem_Click(sender, e);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                if (MessageBox.Show("Want to save?", "Save!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to save?", "Save!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                saveAllToolStripMenuItem_Click(sender, e);
            }
            tabControl1.TabPages.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().SelectAll();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().SelectAll();
            GetSelectedTb().SelectedText = "";
        }

        private void dateshortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Text = GetSelectedTb().Text.Insert(GetSelectedTb().SelectionStart, DateTime.Now.ToShortDateString());
        }

        private void datelongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Text = GetSelectedTb().Text.Insert(GetSelectedTb().SelectionStart, DateTime.Now.ToLongDateString());
        }

        private void timeshortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Text = GetSelectedTb().Text.Insert(GetSelectedTb().SelectionStart, DateTime.Now.ToShortTimeString());
        }

        private void timelongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Text = GetSelectedTb().Text.Insert(GetSelectedTb().SelectionStart, DateTime.Now.ToLongTimeString());
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Text = GetSelectedTb().Text.Insert(GetSelectedTb().SelectionStart, DateTime.Now.ToString());
        }

        private void readOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (readOnlyToolStripMenuItem.Checked)
                GetSelectedTb().ReadOnly = true;
            else
                GetSelectedTb().ReadOnly = false;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Font = new Font(GetSelectedTb().Font.FontFamily, GetSelectedTb().Font.Size + 1);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().Font = new Font(GetSelectedTb().Font.FontFamily, GetSelectedTb().Font.Size - 1);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)
                GetSelectedTb().WordWrap = true;
            else
                GetSelectedTb().WordWrap = false;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GetSelectedTb().SelectionFont = dialog.Font;
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var boldFont = new Font(GetSelectedTb().SelectionFont, FontStyle.Bold))
                GetSelectedTb().SelectionFont = boldFont;
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var boldFont = new Font(GetSelectedTb().SelectionFont, FontStyle.Italic))
                GetSelectedTb().SelectionFont = boldFont;
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var boldFont = new Font(GetSelectedTb().SelectionFont, FontStyle.Underline))
                GetSelectedTb().SelectionFont = boldFont;
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var boldFont = new Font(GetSelectedTb().SelectionFont, FontStyle.Strikeout))
                GetSelectedTb().SelectionFont = boldFont;
        }

        private void textHighlightColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                GetSelectedTb().SelectionBackColor = color.Color;
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                GetSelectedTb().SelectionColor = color.Color;
            }
        }

        private void bulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().SelectionBullet = bulletsToolStripMenuItem.Checked;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().SelectionBullet = false;
            bulletsToolStripMenuItem.Checked = false;
        }

        private void dotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().SelectionBullet = true;
            bulletsToolStripMenuItem.Checked = true;
        }

        private void decreaseIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().SelectionIndent -= 20;
        }

        private void increaseIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTb().SelectionIndent += 20;
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(this, new EventArgs());
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            GetSelectedTb().LoadFile("info.rtf", RichTextBoxStreamType.RichText);
            tabControl1.SelectedTab.Text = Path.GetFileName("info.rtf");
        }
    }
}