using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RemindMyEyes
{
    public partial class frmReminder : Form
    {
        public static int mi;
        public static int se;
        public static int totaltimeleft;

        public frmReminder(int m, int s)
        {
            mi = m;
            se = s;
            InitializeComponent();
        }
        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
        private void frmReminder_Load(object sender, EventArgs e)
        {
            int minutes             = mi * 60;
            int secs                = se;
            int totaltime           = minutes + secs;
            totaltimeleft           = totaltime;
            pb_TimeRemaining.Maximum = totaltime;
            pb_TimeRemaining.Value  = totaltime;
            timer1.Start();
            BlockInput(true);
            this.TopMost = true;
            this.BringToFront();
            Shake(this);
            this.BringToFront();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totaltimeleft -= 1;
            if (totaltimeleft > 0) 
            {
                pb_TimeRemaining.Value = totaltimeleft; 
            }
            lbl_TimeLeft.Text = totaltimeleft.ToString();
            if(totaltimeleft == 0)
            {
                this.Hide();
                BlockInput(false);
                frmMain.enabled = true;
            }
        }

        private void btn_CancelBreak_Click(object sender, EventArgs e)
        {
            totaltimeleft = 1;
        }
        public static void BlockInput(bool toggled)
        {
            if(toggled)
            {
                NativeMethods.BlockInput(true);
            }
            else
            {
                NativeMethods.BlockInput(false);
            }
            
        }//vhttps://stackoverflow.com/questions/586547/how-can-i-block-keyboard-and-mouse-input-in-c
        public partial class NativeMethods
        {

            /// Return Type: BOOL->int
            ///fBlockIt: BOOL->int
            [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool BlockInput([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool fBlockIt);

        }
    }
}
