using System.DirectoryServices.ActiveDirectory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace wfa_Timer
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer tmUp = new();
        private System.Windows.Forms.Timer tmDown = new();
        private DateTime nowTmUp;
        TimeSpan backTmUp;
        private DateTime startTmUp;
        private DateTime pauseTmUp;
        bool value = false;
        bool but_press = false;

        public Form1()
        {
            InitializeComponent();

            tmUp.Interval = 100; //1 sec = 1000
            tmUp.Tick += TmUp_Tick;
        }


        //Tick Происходит по истечении заданного интервала таймера при условии, что таймер включен.
        private void TmUp_Tick(object? sender, EventArgs e)
        {
            System.TimeSpan x;
            if (!value) x = DateTime.Now.Subtract(startTmUp);
            else
            {
                backTmUp = backTmUp.Add(TimeSpan.FromMilliseconds(-100));
                x = backTmUp;
            }

            if (x > nowTmUp.TimeOfDay && !value)
            {
                tmUp.Stop();
                nowTmUp = SetTimeToZero(nowTmUp);
                x = nowTmUp.TimeOfDay;
                backTmUp = nowTmUp.TimeOfDay;
                but_press = false;
                prog_1.Value = 0;
            }
            else if (!value) prog_1.Value = (int)x.TotalSeconds + 1;

            if (x == TimeSpan.Zero && value)
            {
                tmUp.Stop();
                x = TimeSpan.Zero;
                nowTmUp = SetTimeToZero(nowTmUp);
                backTmUp = nowTmUp.TimeOfDay;
                but_press = false;
                prog_1.Value = 0;
            }
            else if (value) prog_1.Value = (int)nowTmUp.TimeOfDay.TotalSeconds - (int)x.TotalSeconds;

            butUp.Text = x.ToString(@"hh\:mm\:ss");
        }

        private void but_h_Click(object sender, EventArgs e)
        {
            nowTmUp = nowTmUp.AddHours(1);
            backTmUp = backTmUp.Add(TimeSpan.FromHours(1));
            prog_1.Maximum = (int)backTmUp.TotalSeconds;
            butUp.Text = nowTmUp.ToString(@"T");
        }

        private void but_m_Click(object sender, EventArgs e)
        {
            nowTmUp = nowTmUp.AddMinutes(1);
            backTmUp = backTmUp.Add(TimeSpan.FromMinutes(1));
            prog_1.Maximum = (int)backTmUp.TotalSeconds;
            butUp.Text = nowTmUp.ToString(@"T");
        }

        private void but_s_Click(object sender, EventArgs e)
        {
            nowTmUp = nowTmUp.AddSeconds(1);
            backTmUp = backTmUp.Add(TimeSpan.FromSeconds(1));
            prog_1.Maximum = (int)backTmUp.TotalSeconds;
            butUp.Text = nowTmUp.ToString(@"T");
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            nowTmUp = SetTimeToZero(nowTmUp);
            backTmUp = nowTmUp.TimeOfDay;
            butUp.Text = nowTmUp.ToString(@"T");
            tmUp.Stop();
            but_press = false;
            prog_1.Value = 0;
        }

        public static DateTime SetTimeToZero(DateTime YourDate)
        {
            return new DateTime(YourDate.Year, YourDate.Month, YourDate.Day, 0, 0, 0);
        }

        private void but_start_pause_Click(object sender, EventArgs e)
        {
            tmUp.Enabled = !tmUp.Enabled;

            if (!but_press && tmUp.Enabled)
            {
                startTmUp = DateTime.Now;
                prog_1.Value = 0;
            }
            else if (tmUp.Enabled) startTmUp = startTmUp + (DateTime.Now - pauseTmUp);
            else
            {
                pauseTmUp = DateTime.Now;
                backTmUp = nowTmUp.TimeOfDay - (pauseTmUp.TimeOfDay - startTmUp.TimeOfDay);
            }

            but_press = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (!tmUp.Enabled)
            {
                if (checkBox.Checked == true) value = true;
                else value = false;
            }
        }
    }
}