using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingRoom_Management_System
{
    public partial class FormKontrolPaneli : Form
    {
        public string Username;
        public FormKontrolPaneli()
        {
            InitializeComponent();
        }
       
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes== result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss tt");
        }

        private void FormKontrolPaneli_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUser.Text = Username;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlSetting1.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();



        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Clear();
            userControlRoom1.Show();
            userControlReservation1.Hide();

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Clear();
            userControlReservation1.Show();


        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSetting);
            userControlSetting1.Clear();
            userControlSetting1.Show();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();

        }

        private void userControlSetting1_Load(object sender, EventArgs e)
        {

        }

        private void userControlReservation1_Load(object sender, EventArgs e)
        {

        }
    }
}
