using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool down, up, left, right;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            right = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (snhe.Location.X<=0&&snhe.Location.Y<371)
                    timer1.Stop();
            else if (snhe.Location.X >= 558 && snhe.Location.Y < 429)
                timer1.Stop();
            else if (snhe.Location.X < 558 && snhe.Location.Y <= 0)
                timer1.Stop();
            else if (snhe.Location.X < 558 && snhe.Location.Y >= 429)
                timer1.Stop();
            if (up == true)
            {
                bdown.Enabled = false;bleft.Enabled = true;bright.Enabled = true;
                body.Location = new Point(snhe.Location.X, snhe.Location.Y+17);
                snhe.Location = new Point(snhe.Location.X, snhe.Location.Y - 10);
                if (right == true)
                    snhe.Location = new Point(snhe.Location.X - 10, snhe.Location.Y - 10);
                if (left == true)
                    snhe.Location = new Point(snhe.Location.X + 10, snhe.Location.X - 10);
            }
            if (right == true)
            {
                bdown.Enabled = true; bleft.Enabled = false; bup.Enabled = true;
                bleft.Enabled = false;
                body.Location = new Point(snhe.Location.X-17, snhe.Location.Y);
                snhe.Location = new Point(snhe.Location.X + 10, snhe.Location.Y);
                if (up == true)
                    snhe.Location = new Point(snhe.Location.X + 10, snhe.Location.Y + 10);
                if (down == true)
                    snhe.Location = new Point(snhe.Location.X + 10, snhe.Location.Y - 10);

            }
            if (left == true)
            {
                bright.Enabled = false;bup.Enabled = true;bdown.Enabled = true;
                body.Location = new Point(snhe.Location.X + 17, snhe.Location.Y);
                snhe.Location = new Point(snhe.Location.X - 10, snhe.Location.Y);
                if (up == true)
                    snhe.Location = new Point(snhe.Location.X - 10, snhe.Location.Y + 10);
                if (down == true)
                    snhe.Location = new Point(snhe.Location.X - 10, snhe.Location.Y - 10);
            }
            if (down == true)
            {
                bup.Enabled = false;bleft.Enabled = true;bright.Enabled = true;
                body.Location = new Point(snhe.Location.X, snhe.Location.Y-17);
                snhe.Location = new Point(snhe.Location.X, snhe.Location.Y + 10);
                if (right == true)
                    snhe.Location = new Point(snhe.Location.X - 5, snhe.Location.Y + 5);
                if (left == true)
                    snhe.Location = new Point(snhe.Location.X + 5, snhe.Location.Y + 5);
            }
            if (snhe.Location.X == 0 && snhe.Location.Y < 371)
                timer1.Stop();
            else if (snhe.Location.X == 558 && snhe.Location.Y < 429)
                timer1.Stop();
            else if (snhe.Location.X < 558 && snhe.Location.Y == 0)
                timer1.Stop();
            else if (snhe.Location.X < 558 && snhe.Location.Y == 429)
                timer1.Stop();

        }

        private void bright_Click(object sender, EventArgs e)
        {
            right = true;
            up = false;
            left = false;
            down = false;
        }

        private void bdown_Click(object sender, EventArgs e)
        {
            up = false; down = true; left = false; right = false;
        }

        private void bleft_Click(object sender, EventArgs e)
        {
            left = true;
            right = false;
            down = false;
            up = false;
        }

        private void bup_Click(object sender, EventArgs e)
        {
            up = true;
            down = false;
            left = false;
            right = false;
        }

        private void body_Click(object sender, EventArgs e)
        {

        }
    }
}
