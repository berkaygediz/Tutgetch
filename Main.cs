using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tutgetch
{
    public partial class Main : Form
    {
        int MoveCP;
        int MapX;
        int MapY;
        public Main()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Control.Stop();
            Time.Stop();
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveCP = 1;
            MapX = e.X;
            MapY = e.Y;
        }
        private void ControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveCP = 0;
        }
        private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveCP == 1)
            {
                SetDesktopLocation(MousePosition.X - MapX, MousePosition.Y - MapY);
            }
        }

        readonly Random randompoint = new Random();
        int chance = 5;
        int yourtime = 10;

        private void Start_Click(object sender, EventArgs e)
        {
            Control.Start();
            Time.Start();
            chance = 5;
            yourtime = 10;
        }

        private void Control_Tick(object sender, EventArgs e)
        {
            LabelChance.Text = "Chance: " + chance.ToString();
            label_time.Text = "Time: " + yourtime.ToString();
            if (chance == 0)
            {
                Start.Enabled = true;
                Reset.Enabled = true;
                Dot.Visible = false;
                Time.Stop();
            }
            else
            {
                GamePanel.BackColor = Color.FromArgb(randompoint.Next(255), randompoint.Next(255), randompoint.Next(255));
                Dot.Location = new Point(randompoint.Next(340), randompoint.Next(340));
                Start.Enabled = false;
                Dot.Visible = true;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Control.Stop();
            Time.Stop();
            Hide();
            new Win().ShowDialog();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Control.Stop();
            Time.Stop();
            chance = 5;
            Start.Enabled = true;
            Reset.Enabled = false;
            Dot.Visible = false;
            LabelChance.Text = "Chance: " + chance.ToString();
            label_time.Text = "Time: " + yourtime.ToString();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (yourtime == 0)
            {
                yourtime += 10;
                Control.Stop();
                Time.Stop();
                Start.Enabled = true;
                Dot.Enabled = false;
            }
            else
            {
                yourtime--;
                Start.Enabled = false;
                Dot.Enabled = true;
            }
            label_time.Text = "Time: " + yourtime.ToString();
        }

        private void GamePanel_MouseDown(object sender, MouseEventArgs e)
        {
            LabelChance.Text = "Chance: " + chance.ToString();
            if (chance == 0)
            {
                Reset.Enabled = true;
                Start.Enabled = true;
                MessageBox.Show("Game over!");
            }
            else
            {
                chance--;
            }
        }
    }
}
