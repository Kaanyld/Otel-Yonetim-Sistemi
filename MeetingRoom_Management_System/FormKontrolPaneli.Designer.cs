namespace MeetingRoom_Management_System
{
    partial class FormKontrolPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControlRoom1 = new MeetingRoom_Management_System.User_Control.UserControlRoom();
            this.userControlClient1 = new MeetingRoom_Management_System.User_Control.UserControlClient();
            this.userControlSetting1 = new MeetingRoom_Management_System.User_Control.UserControlSetting();
            this.userControlReservation1 = new MeetingRoom_Management_System.User_Control.UserControlReservation();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.buttonSetting);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 720);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 232);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 48);
            this.panelSlide.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetting.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.Location = new System.Drawing.Point(21, 544);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(202, 48);
            this.buttonSetting.TabIndex = 5;
            this.buttonSetting.Text = "Ayarlar";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservation.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Location = new System.Drawing.Point(21, 470);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(202, 48);
            this.buttonReservation.TabIndex = 4;
            this.buttonReservation.Text = "Rezervasyon";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoom.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.ForeColor = System.Drawing.Color.White;
            this.buttonRoom.Location = new System.Drawing.Point(21, 391);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(202, 48);
            this.buttonRoom.TabIndex = 3;
            this.buttonRoom.Text = "Oda";
            this.buttonRoom.UseVisualStyleBackColor = false;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Location = new System.Drawing.Point(21, 310);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(202, 48);
            this.buttonClient.TabIndex = 2;
            this.buttonClient.Text = "Müşteri";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(21, 232);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(202, 48);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Kontrol Paneli";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 226);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rezervasyon Sistemi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MeetingRoom_Management_System.Properties.Resources._25694;
            this.pictureBox2.Location = new System.Drawing.Point(21, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(260, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1540, 129);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaan Yıldırım © 2023";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Controls.Add(this.labelUser);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(260, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1540, 226);
            this.panel4.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(150, 161);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(21, 23);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hoşgeldin:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.labelDateTime);
            this.panel5.Controls.Add(this.linkLabelLogOut);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1540, 105);
            this.panel5.TabIndex = 0;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDateTime.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelDateTime.Location = new System.Drawing.Point(16, 58);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(21, 23);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "?";
            this.labelDateTime.Click += new System.EventHandler(this.labelDateTime_Click);
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogOut.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogOut.Location = new System.Drawing.Point(1194, 58);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(94, 35);
            this.linkLabelLogOut.TabIndex = 0;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "LogOut";
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MeetingRoom_Management_System.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(1067, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userControlReservation1);
            this.panel6.Controls.Add(this.userControlRoom1);
            this.panel6.Controls.Add(this.userControlClient1);
            this.panel6.Controls.Add(this.userControlSetting1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(260, 226);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1540, 365);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.BackColor = System.Drawing.Color.White;
            this.userControlRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoom1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userControlRoom1.Location = new System.Drawing.Point(0, 0);
            this.userControlRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1540, 365);
            this.userControlRoom1.TabIndex = 0;
            this.userControlRoom1.Visible = false;
            // 
            // userControlClient1
            // 
            this.userControlClient1.BackColor = System.Drawing.Color.White;
            this.userControlClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClient1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userControlClient1.Location = new System.Drawing.Point(0, 0);
            this.userControlClient1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1540, 365);
            this.userControlClient1.TabIndex = 0;
            this.userControlClient1.Visible = false;
            // 
            // userControlSetting1
            // 
            this.userControlSetting1.BackColor = System.Drawing.Color.White;
            this.userControlSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userControlSetting1.Location = new System.Drawing.Point(0, 0);
            this.userControlSetting1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetting1.Name = "userControlSetting1";
            this.userControlSetting1.Size = new System.Drawing.Size(1540, 365);
            this.userControlSetting1.TabIndex = 0;
            this.userControlSetting1.Visible = false;
            this.userControlSetting1.Load += new System.EventHandler(this.userControlSetting1_Load);
            // 
            // userControlReservation1
            // 
            this.userControlReservation1.BackColor = System.Drawing.Color.White;
            this.userControlReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReservation1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userControlReservation1.Location = new System.Drawing.Point(0, 0);
            this.userControlReservation1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlReservation1.Name = "userControlReservation1";
            this.userControlReservation1.Size = new System.Drawing.Size(1540, 365);
            this.userControlReservation1.TabIndex = 0;
            this.userControlReservation1.Visible = false;
            // 
            // FormKontrolPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 720);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKontrolPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKontrolPaneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKontrolPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelSlide;
        private User_Control.UserControlSetting userControlSetting1;
        private User_Control.UserControlClient userControlClient1;
        private User_Control.UserControlRoom userControlRoom1;
        private User_Control.UserControlReservation userControlReservation1;
    }
}