using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuneAutoClicker
{
    public partial class Form1 : Form
    {
        private int delay = 1000;
        private int rndDelay = 500;
        private int minDClickDelay = 200;
        private int maxDClickDelay = 500;
        private int dClickDelay = 0;
        private Boolean isDoubleClick;
        private Boolean isClicking;
        WindowsInput.InputSimulator cc = new WindowsInput.InputSimulator();
        Random rng = new Random();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }



        public Form1()
        {
            InitializeComponent();
            int id = 0;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Control, Keys.L.GetHashCode()); // Registers the hotkey as CTRL + L
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {

                isClicking = !isClicking;

                if (!isClicking)
                {
                    startTimer();
                }
                else
                {
                    stopTimer();
                }

            }
        }

        public void DoMouseClick()
        {
            cc.Mouse.LeftButtonClick(); // Left-click.
        }

        private void nudMaxDouble_ValueChanged(object sender, EventArgs e)
        {
            maxDClickDelay = Convert.ToInt32(nudMaxDouble.Value);
        }

        private void nudMinDouble_ValueChanged(object sender, EventArgs e)
        {
            minDClickDelay = Convert.ToInt32(nudMinDouble.Value);
        }

        private void nudDelay_ValueChanged(object sender, EventArgs e)
        {
            delay = Convert.ToInt32(nudDelay.Value) ;  
        }

        private void nudRandom_ValueChanged(object sender, EventArgs e)
        {
            rndDelay = Convert.ToInt32(nudRandom.Value);
        }

        private void cbDoubleClick_CheckedChanged(object sender, EventArgs e)
        {
            isDoubleClick = !isDoubleClick; 
            nudMaxDouble.Enabled = !nudMaxDouble.Enabled;
            nudMinDouble.Enabled = !nudMinDouble.Enabled;
            lblMaxDC.Enabled = !lblMaxDC.Enabled;
            lblMinDC.Enabled = !lblMinDC.Enabled;
        }



        private void startTimer()
        {
            timerClick.Interval = delay;
            timerClick.Start();
        }

        private void stopTimer()
        {
            timerClick.Stop();
        }

        private async void timerClick_Tick_1(object sender, EventArgs e)
        {
            int rndDelayL = rng.Next(0, rndDelay);

            if (isDoubleClick)
            {
                dClickDelay = rng.Next(minDClickDelay, maxDClickDelay);
                timerClick.Interval = delay + rndDelayL + dClickDelay;
            }
            else
            {
                timerClick.Interval = delay + rndDelayL;
            }
            performClick();
        }

        private async void performClick()
        {
            if (isDoubleClick)
            {
                DoMouseClick();
                await Task.Delay(dClickDelay);
            }

                DoMouseClick();
        }


        private void ExampleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey on closing application.
        }

    }
}
