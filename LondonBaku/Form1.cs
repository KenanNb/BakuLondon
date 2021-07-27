using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LondonBaku
{
    public partial class timeLbl : Form
    {
       // private readonly PictureBox pictureBox = new PictureBox();       
       
        Timer Timer = new Timer();

        public timeLbl()
        {            
            InitializeComponent();
            //Controls.Add(pictureBox);
            //bakuBtn_MouseClick(bakuBtn, new EventArgs());
        }
        private void timeLbl_Load(object sender, EventArgs e)
        {

        }
        
        public void Timer_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
            label1.Text = DateTime.Now.ToLongTimeString();
        }
        public void TimerLndn_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.AddHours(4).ToLongTimeString();
            label1.Text = DateTime.Now.AddHours(4).ToLongTimeString();
        }

        private void londonBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Timer.Stop();
            Timer.Tick += TimerLndn_Tick;
            Timer.Interval = 1000;
            this.BackgroundImage = Properties.Resources._london_flights;

            Timer.Start();
            this.Text = DateTime.Now.AddHours(4).ToLongTimeString();            
            londonBtn.BackColor = Color.DarkTurquoise;
            bakuBtn.BackColor = Color.Red;
           
        }

        private void bakuBtn_MouseClick(object sender, MouseEventArgs e)
        {
           
            Timer.Stop();
            Timer.Tick += Timer_Tick;
            Timer.Interval = 1000;
            
            this.BackgroundImage = Properties.Resources.Baku_Azerbaijan_Caspian_Sea;
            
            Timer.Start();
            this.Text = DateTime.Now.ToString("HH:mm:ss");
            bakuBtn.BackColor = Color.DarkTurquoise;
            londonBtn.BackColor = Color.Red;
           
        }

    }
}
