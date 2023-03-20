using Timer = System.Threading.Timer;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random random;
        int sec = 0;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Position : {e.X}:{e.Y}";
            Point mouse = e.Location;
            
             if (mouse.X >= but_running.Left - 15 && mouse.X <= but_running.Left + but_running.Width + 15 )
            {
                if (mouse.X >= but_running.Left)
                {
                    but_running.Left = but_running.Left - 15;
                }
                else
                {
                    but_running.Left = but_running.Left + 15;
                }
            }
           if (mouse.Y >= but_running.Top-15 && mouse.Y <= but_running.Top +but_running.Height+ 15)
            {
                if (mouse.Y > but_running.Top)
                {
                    but_running.Top = but_running.Top - 15;
                }
                else
                {
                   but_running.Top = but_running.Top + 15;
                }
            }
            
            if (but_running.Left < 0)
            {
                but_running.Location = new Point(random.Next(this.Width), random.Next(this.Height));

            }
            if (but_running.Left + but_running.Width > this.ClientSize.Width)
            {
                but_running.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
            if (but_running.Location.Y < 0)
            {
                but_running.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
            if (but_running.Location.Y > this.ClientSize.Height - but_running.Height)
            {
                but_running.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
        }

        private void but_running_MouseClick(object sender, MouseEventArgs e)
        {
            but_running.Text = "You won!";
            but_running.BackColor = Color.Green;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (++sec).ToString();
            if (sec == 10)
            {
                but_running.BackColor = Color.Red;
                but_running.Text = "Catch me";
                timer1.Stop();
                sec = 0;
            }
        }
    }
}