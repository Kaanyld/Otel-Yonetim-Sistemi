using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AMRConnector;
using System.Data.SqlClient;


namespace MeetingRoom_Management_System
{
    public partial class FormLogIn : Form
    {
        DbConnector db;
        public FormLogIn()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            bool check = db.IsValidNamePass(textBoxUser.Text.Trim(),textBoxPassword.Text.Trim());
            if(textBoxUser.Text.Trim()== string.Empty || textBoxPassword.Text.Trim()== string.Empty) 
                MessageBox.Show("Lütfen tüm alanları doldurun!","Zorunlu Alan",MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if(check)
                {
                    FormKontrolPaneli fk = new FormKontrolPaneli();
                    fk.Username=textBoxUser.Text;
                    textBoxUser.Clear();
                    textBoxPassword.Clear();
                    fk.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Kullanıcı Adı veya Şifre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
