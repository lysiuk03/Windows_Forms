using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace hotel
{
    public partial class Form1 : Form
    {
        Hotel myhotel = new Hotel();
        public Form1()
        {
            InitializeComponent(); 
        }
        [Serializable]
        class Visitors
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Phone { get; set; }
            public int People { get; set; }
            public string Room { get; set; }
            public DateTime From { get; set; }
            public DateTime To { get; set; }
            public string Comm { get; set; }

            public Visitors(string name, string surname, string phone, int people, string room, DateTime from, DateTime to, string comm)
            {
                Name = name;
                Surname = surname;
                Phone = phone;
                People = people;
                Room = room;
                From = from;
                To = to;
                Comm = comm;
            }
            public override string ToString()
            {
                return $" Name:  {Name}\n Surname: {Surname}\n Phone: { Phone}\n People:  {People}\n Room: {Room}\n From: {From.Day}.{From.Month}.{From.Year}\n To: {To.Day}.{To.Month}.{To.Year}\n Comm:  {Comm} ";
            }
        }
        [Serializable]
        class Hotel
        {
            Dictionary<int, Visitors> visit = new Dictionary<int, Visitors>();
            private static int id = 1;
            private int GetID()
            {
                return id++;
            }
            public void Add(Visitors v)
            {
               visit.Add(GetID(), v);
            }
            public void Download()
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                visit = null;
                using (Stream fstream = File.OpenRead("Hotel.bin"))
                {
                    visit = (Dictionary<int, Visitors>)binaryFormatter.Deserialize(fstream);
                }
                foreach (var v in visit)
                {
                    id = v.Key;
                }
                id++;
            }
            public void Save()
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (Stream fstream = File.Create("Hotel.bin"))
                {
                    binaryFormatter.Serialize(fstream, visit);
                }
            }
            public override string ToString()
            {
                string str=" ";
                foreach (var v in visit)
                {
                    str = str+v.ToString()+"\n";
                }
                return str;
            }
        }
        private bool IsSelectedterms()
        {
            return (checkBox1.Checked && checkBox2.Checked);
        }
        private bool FilledData()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                if(item.Text == "")
                    return false;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                return false;
            if (maskedTextBox_phone.Text == "+(38 )   -   -  -")
                return false;

            return true;

        }
        private void Clear()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
            foreach (var item in this.Controls.OfType<CheckBox>())
            {
                item.Checked = false;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false; 
            radioButton3.Checked = false;
            maskedTextBox_phone.Clear();
            numericUpDown_count.Value = 1;
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now;
            button_save.Enabled = false;
        }
   
        private void button_save_Click(object sender, EventArgs e)
        {
            if(!FilledData())
            {
                MessageBox.Show("Fill in all the details!");
                return;
            }
            /* StringBuilder res = new StringBuilder("==========INFO===========\n");
             res.Append("Name: " + textBox_name.Text);
             res = res.AppendLine();
             res.Append("Surname: " + textBox_surname.Text);
             res = res.AppendLine();

             res.Append("Phone: " + maskedTextBox_phone.Text);
             res = res.AppendLine();

             res.Append("People: " + numericUpDown_count.Value);
             res = res.AppendLine();

             res.Append("Room: ");
             if (radioButton1.Checked)
                 res.Append("Econom");
             if (radioButton2.Checked)
                 res.Append("Standart");
             if (radioButton3.Checked)
                 res.Append("Luxe");
             res = res.AppendLine();


             res.Append("From: " + monthCalendar1.SelectionStart);
             res = res.AppendLine();
             res.Append("To: " + monthCalendar1.SelectionEnd);
             res = res.AppendLine();

             res.Append("Comment: " + textBox_comment.Text);
             res = res.AppendLine();

             MessageBox.Show(res.ToString());*/
            
            string name,surname, phone, comm, room = " ";
            int people;
            DateTime from, to;
            name = textBox_name.Text;
            surname = textBox_surname.Text;
            phone = maskedTextBox_phone.Text;
            people = (int)numericUpDown_count.Value;
            if (radioButton1.Checked)
                room="Econom";
            if (radioButton2.Checked)
                room = "Standart";
            if (radioButton3.Checked)
                room = "Luxe";
            from = monthCalendar1.SelectionStart;
            to = monthCalendar1.SelectionEnd;
            comm = textBox_comment.Text;
            Visitors v = new Visitors(name, surname, phone, people, room, from, to, comm);
            if (MessageBox.Show("==========INFO==========\n"+v.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if(MessageBox.Show("Want to save?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    myhotel.Add(v);
                    myhotel.Save();
                }
            }
        }
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(IsSelectedterms())
            button_save.Enabled = true;
            else
                button_save.Enabled = false;
        }
        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsSelectedterms())
                button_save.Enabled = true;
            else
                button_save.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            myhotel.Download();
            MessageBox.Show(myhotel.ToString());
        }

    }
 
}

