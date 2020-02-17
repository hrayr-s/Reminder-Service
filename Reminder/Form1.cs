using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Media;
namespace Reminder
{
    public partial class mainform : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        public bool havealarm = false;

        WMPLib.WindowsMediaPlayer player;

        public struct alarms
        {
            public string name;
            public string Description;
            public int id;
            public DateTime alarm;
            public string muspath;
        }

        public alarms[] allalarms = new alarms[15];

        DateTime currentAlarm;
        
        public mainform()
        {
            InitializeComponent();
            SysTrayApp();
            checkAlarm();
            this.player = new WMPLib.WindowsMediaPlayer();


        }

        private void repeatit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Time.Text;
            makeAnAlarm(alname.Text, aldescr.Text, alarmsets.Value, false);
        }


        public void SysTrayApp()
        {
            // Create a simple tray menu with only 2 item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Ցույց տալ/թաքցնել", showhide);
            trayMenu.MenuItems.Add("Դուրս գալ", OnExit);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Զարթուցիչ";
            trayIcon.Icon = new Icon("icon.ico", 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            trayIcon.BalloonTipClicked += new System.EventHandler(NotifyIcon1_Click);
        }

        private void showhide(object sender, EventArgs e)
        {
            if (Visible)
            {
                Visible = false;
                ShowInTaskbar = false;
            }
            else
            {
                Visible = true;
                ShowInTaskbar = true;
            }
        }
        
        protected override void OnLoad(EventArgs e)
        {
            //Visible = false; // Hide form window.
            //ShowInTaskbar = false; // Remove from taskbar.
            //button2.Hide();
            //label4.Hide();
            repeatit.Hide();
            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void makeAnAlarm(string name, string description, DateTime dtime, bool repeat)
        {

            //string param = "";
            //param = name + ":" + attime + ":" + repeat;
            this.currentAlarm = dtime;
            allalarms[0].name = name;
            allalarms[0].Description = description;
            allalarms[0].id = 0;
            allalarms[0].alarm = dtime;
            if(allalarms[0].muspath==null)
                allalarms[0].muspath = "song.wav";
            currentAlarm = dtime;
            havealarm = true;
            /*// Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("CurrentAlarm.ini");
            file.WriteLine(param);
            file.Close();*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkAlarm()
        {
            int waittime = 1000;
            Task al = Task.Run(() =>
            {
                while (true)
                {
                    if(currentAlarm!=null && havealarm)
                        if (DateTime.Now.Year==currentAlarm.Year)
                        {
                            if (DateTime.Now.Month == currentAlarm.Month)
                            {
                                if (DateTime.Now.Day==currentAlarm.Day)
                                {
                                    waittime = 60 * 60 * 1000;
                                    if (DateTime.Now.Hour==currentAlarm.Hour)
                                    {
                                        waittime = 60 * 1000;
                                        if (DateTime.Now.Minute==currentAlarm.Minute)
                                        {
                                            waittime = 1000;
                                            if (DateTime.Now.Second >= currentAlarm.Second)
                                            {
                                                trayIcon.ShowBalloonTip(300000000, allalarms[0].name+" ", allalarms[0].Description+" ", ToolTipIcon.Info);
                                                playSound(allalarms[0].muspath);
                                                havealarm = false;
                                            }
                                        } else
                                        {
                                            if(DateTime.Now.Minute <= currentAlarm.Minute && DateTime.Now.Second - currentAlarm.Second < 60)
                                            {
                                                waittime = 1000;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    /*BeginInvoke((Action)(() =>
                    {
                        label4.Text = ("waittime=" + waittime + "\t  currentalarm=" + currentAlarm.ToString()+"\t Time="+DateTime.Now.ToString());
                    }));*/

                    Thread.Sleep(waittime);
                }
            });
        }

        public void NotifyIcon1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void playSound(string path)
        {
            player.URL = path;
            player.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Audio Files (.wav)|*.wav|(.mp3)|*.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.allalarms[0].muspath = openFileDialog1.FileName;
            }
        }
    }
}
