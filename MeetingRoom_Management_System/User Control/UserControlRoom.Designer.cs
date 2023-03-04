namespace MeetingRoom_Management_System.User_Control
{
    partial class UserControlRoom
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchRoomNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndDeleteRoom = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNo1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.tabPageUpdateAndDeleteRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpdateAndDeleteRoom);
            this.tabControlRoom.Location = new System.Drawing.Point(36, 14);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1031, 417);
            this.tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.radioButtonNo);
            this.tabPageAddRoom.Controls.Add(this.radioButtonYes);
            this.tabPageAddRoom.Controls.Add(this.comboBoxType);
            this.tabPageAddRoom.Controls.Add(this.buttonAdd);
            this.tabPageAddRoom.Controls.Add(this.textBoxPhoneNo);
            this.tabPageAddRoom.Controls.Add(this.label3);
            this.tabPageAddRoom.Controls.Add(this.label4);
            this.tabPageAddRoom.Controls.Add(this.label2);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1023, 383);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Oda Ekle";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            this.tabPageAddRoom.Leave += new System.EventHandler(this.tabPageAddRoom_Leave);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(281, 227);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(71, 25);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Hayır";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(281, 196);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(69, 25);
            this.radioButtonYes.TabIndex = 3;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Evet";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Lütfen seçim yapın..!",
            "Tek",
            "Çift",
            "Aile",
            "Suit"});
            this.comboBoxType.Location = new System.Drawing.Point(213, 113);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(264, 29);
            this.comboBoxType.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(213, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 49);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "EKLE";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPhoneNo.Location = new System.Drawing.Point(565, 114);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(256, 28);
            this.textBoxPhoneNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(561, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon No.:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(209, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müsait:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(209, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oda Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda Ekle:";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewRoom);
            this.tabPageSearchRoom.Controls.Add(this.textBoxSearchRoomNo);
            this.tabPageSearchRoom.Controls.Add(this.label5);
            this.tabPageSearchRoom.Controls.Add(this.label6);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1023, 383);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Oda Ara";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            this.tabPageSearchRoom.Enter += new System.EventHandler(this.tabPageSearchRoom_Enter);
            this.tabPageSearchRoom.Leave += new System.EventHandler(this.tabPageSearchRoom_Leave);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewRoom.Location = new System.Drawing.Point(6, 142);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.Size = new System.Drawing.Size(1011, 218);
            this.dataGridViewRoom.TabIndex = 0;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            this.dataGridViewRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Room_Number";
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room_Type";
            this.Column2.HeaderText = "Tip";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_Phone";
            this.Column3.HeaderText = "Telefon";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Room_Free";
            this.Column4.HeaderText = "Müsait mi?";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBoxSearchRoomNo
            // 
            this.textBoxSearchRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchRoomNo.Location = new System.Drawing.Point(179, 77);
            this.textBoxSearchRoomNo.Name = "textBoxSearchRoomNo";
            this.textBoxSearchRoomNo.Size = new System.Drawing.Size(238, 28);
            this.textBoxSearchRoomNo.TabIndex = 1;
            this.textBoxSearchRoomNo.TextChanged += new System.EventHandler(this.textBoxSearchRoomNo_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(175, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Oda Numarası.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oda Ara:";
            // 
            // tabPageUpdateAndDeleteRoom
            // 
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.radioButtonNo1);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.radioButtonYes1);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.textBoxPhoneNo1);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.label7);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.label8);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.label9);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.label10);
            this.tabPageUpdateAndDeleteRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDeleteRoom.Name = "tabPageUpdateAndDeleteRoom";
            this.tabPageUpdateAndDeleteRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDeleteRoom.Size = new System.Drawing.Size(1023, 383);
            this.tabPageUpdateAndDeleteRoom.TabIndex = 2;
            this.tabPageUpdateAndDeleteRoom.Text = "Oda Sil ve Güncelle";
            this.tabPageUpdateAndDeleteRoom.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndDeleteRoom.Leave += new System.EventHandler(this.tabPageUpdateAndDeleteRoom_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(342, 281);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 43);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.Green;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(216, 281);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(115, 43);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.Location = new System.Drawing.Point(284, 227);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(71, 25);
            this.radioButtonNo1.TabIndex = 4;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "Hayır";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.Location = new System.Drawing.Point(284, 196);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(69, 25);
            this.radioButtonYes1.TabIndex = 3;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Evet";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Lütfen seçim yapın..!",
            "Küçük",
            "Orta",
            "Büyük"});
            this.comboBoxType1.Location = new System.Drawing.Point(216, 113);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(264, 29);
            this.comboBoxType1.TabIndex = 1;
            // 
            // textBoxPhoneNo1
            // 
            this.textBoxPhoneNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPhoneNo1.Location = new System.Drawing.Point(568, 114);
            this.textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            this.textBoxPhoneNo1.Size = new System.Drawing.Size(256, 28);
            this.textBoxPhoneNo1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(564, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon No.:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(212, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Müsait:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(212, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Oda Tipi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Oda Sil ve Güncelle:";
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlRoom_Load);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.tabPageUpdateAndDeleteRoom.ResumeLayout(false);
            this.tabPageUpdateAndDeleteRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteRoom;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxSearchRoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.TextBox textBoxPhoneNo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
