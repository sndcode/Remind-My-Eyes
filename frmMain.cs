using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net.Security;

namespace RemindMyEyes
{
    public partial class frmMain : Form
    {
        public static int duration_minutes;
        public static int duration_seconds;
        public static int timespan_minutes;
        public static int timespan_seconds;
        public static int seconds_left;
        public static bool enabled = false;
        public static DateTime starttime;
        public static string settingsfile_path = "C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\remindme.ini";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void m_LoadSettings(string path)
        {
            if(!File.Exists(settingsfile_path))
            {
                File.Create(settingsfile_path).Close();
            }
            var ini = new classINI(path);
            try
            {
                duration_minutes = Convert.ToInt32(ini.Read("duration_minutes"));
                duration_seconds = Convert.ToInt32(ini.Read("duration_seconds"));
                timespan_minutes = Convert.ToInt32(ini.Read("timespan_minutes"));
                timespan_seconds = Convert.ToInt32(ini.Read("timespan_seconds"));

                txt_Minutes_BreakTime.Text = timespan_minutes.ToString();
                txt_Seconds_BreakTime.Text = timespan_seconds.ToString();

                txt_Minutes_Duration.Text = duration_minutes.ToString();
                txt_Seconds_Duration.Text = duration_seconds.ToString();
            }
            catch
            {

            }
        }
        private void m_SaveSettings(string path)
        {
            if (!File.Exists(settingsfile_path))
            {
                File.Create(settingsfile_path).Close();
            }
            var ini = new classINI(path);
            ini.Write("duration_minutes", duration_minutes.ToString());
            ini.Write("duration_seconds", duration_seconds.ToString());
            ini.Write("timespan_minutes", timespan_minutes.ToString());
            ini.Write("timespan_seconds", timespan_seconds.ToString());
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            duration_minutes = Convert.ToInt32(txt_Minutes_Duration.Text);
            duration_seconds = Convert.ToInt32(txt_Seconds_Duration.Text);
            timespan_minutes = Convert.ToInt32(txt_Minutes_BreakTime.Text);
            timespan_seconds = Convert.ToInt32(txt_Seconds_BreakTime.Text);
            m_SaveSettings(settingsfile_path);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            m_LoadSettings(settingsfile_path);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            duration_minutes = Convert.ToInt32(txt_Minutes_Duration.Text);
            duration_seconds = Convert.ToInt32(txt_Seconds_Duration.Text);
            timespan_minutes = Convert.ToInt32(txt_Minutes_BreakTime.Text);
            timespan_seconds = Convert.ToInt32(txt_Seconds_BreakTime.Text);

            this.WindowState = FormWindowState.Minimized;
            enabled = true;
            timer1.Enabled = true;
            int minutestoseconds = duration_minutes * 60;
            int seconds = duration_seconds;
            int totaltime = minutestoseconds + seconds;
            m_BackgroundWatch(totaltime);

        }
        public void m_BackgroundWatch(int secs)
        {
           seconds_left = secs;
           m_CreateTimer();
        }

        private void m_CreateTimer()
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
      
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            enabled = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(enabled)
            {
                if(seconds_left < 0 )
                {
                    int minutestoseconds = duration_minutes * 60;
                    int seconds = duration_seconds;
                    int totaltime = minutestoseconds + seconds;
                    seconds_left = totaltime;
                }
                int itimeleft = seconds_left / 60;
                string stimeleft = itimeleft.ToString();
                lbl_TimeLeft_Mins.Text = stimeleft + " Minutes";
                lbl_TimeLeft_Secs.Text = seconds_left + " Seconds";

                seconds_left -= 1;
                if (seconds_left == 0)
                {
                    frmReminder rem = new frmReminder(timespan_minutes, timespan_seconds);
                    rem.Show(); 
                    enabled = false;
                }
            }
        }
    }
}
