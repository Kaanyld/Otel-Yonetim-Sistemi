namespace MeetingRoom_Management_System.User_Control
{
    partial class UserControlReservation
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
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNo = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchReservation = new System.Windows.Forms.TabPage();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchClientID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndCancelReservation = new System.Windows.Forms.TabPage();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNo1 = new System.Windows.Forms.ComboBox();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxClientID1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tabPageUpdateAndCancelReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchReservation);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateAndCancelReservation);
            this.tabControlReservation.Location = new System.Drawing.Point(-9, -29);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1102, 462);
            this.tabControlReservation.TabIndex = 0;
            this.tabControlReservation.Leave += new System.EventHandler(this.tabControlReservation_Leave);
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddReservation.Controls.Add(this.comboBoxNo);
            this.tabPageAddReservation.Controls.Add(this.comboBoxType);
            this.tabPageAddReservation.Controls.Add(this.buttonAdd);
            this.tabPageAddReservation.Controls.Add(this.label3);
            this.tabPageAddReservation.Controls.Add(this.textBoxClientID);
            this.tabPageAddReservation.Controls.Add(this.label6);
            this.tabPageAddReservation.Controls.Add(this.label5);
            this.tabPageAddReservation.Controls.Add(this.label4);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1094, 428);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Rezervasyon Ekle";
            this.tabPageAddReservation.UseVisualStyleBackColor = true;
            this.tabPageAddReservation.Leave += new System.EventHandler(this.tabPageAddReservation_Leave);
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut.Location = new System.Drawing.Point(615, 269);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(264, 28);
            this.dateTimePickerOut.TabIndex = 5;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn.Location = new System.Drawing.Point(263, 269);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(264, 28);
            this.dateTimePickerIn.TabIndex = 4;
            // 
            // comboBoxNo
            // 
            this.comboBoxNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo.FormattingEnabled = true;
            this.comboBoxNo.Items.AddRange(new object[] {
            "Lütfen seçim yapın.."});
            this.comboBoxNo.Location = new System.Drawing.Point(615, 114);
            this.comboBoxNo.Name = "comboBoxNo";
            this.comboBoxNo.Size = new System.Drawing.Size(238, 29);
            this.comboBoxNo.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Lütfen seçim yapın..",
            "Tek",
            "Çift",
            "Aile",
            "Suit"});
            this.comboBoxType.Location = new System.Drawing.Point(263, 114);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(238, 29);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
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
            this.buttonAdd.Location = new System.Drawing.Point(263, 323);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 46);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "EKLE";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(611, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oda No.:";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID.Location = new System.Drawing.Point(263, 195);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(238, 28);
            this.textBoxClientID.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(611, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Çıkış:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(259, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giriş:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(259, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri No.:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(259, 78);
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
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervasyon Ekle:";
            // 
            // tabPageSearchReservation
            // 
            this.tabPageSearchReservation.Controls.Add(this.dataGridViewReservation);
            this.tabPageSearchReservation.Controls.Add(this.textBoxSearchClientID);
            this.tabPageSearchReservation.Controls.Add(this.label13);
            this.tabPageSearchReservation.Controls.Add(this.label14);
            this.tabPageSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReservation.Name = "tabPageSearchReservation";
            this.tabPageSearchReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchReservation.Size = new System.Drawing.Size(1094, 428);
            this.tabPageSearchReservation.TabIndex = 1;
            this.tabPageSearchReservation.Text = "Rezervasyon Ara";
            this.tabPageSearchReservation.UseVisualStyleBackColor = true;
            this.tabPageSearchReservation.Enter += new System.EventHandler(this.tabPageSearchReservation_Enter);
            this.tabPageSearchReservation.Leave += new System.EventHandler(this.tabPageSearchReservation_Leave);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewReservation.Location = new System.Drawing.Point(46, 165);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersWidth = 51;
            this.dataGridViewReservation.RowTemplate.Height = 24;
            this.dataGridViewReservation.Size = new System.Drawing.Size(1007, 218);
            this.dataGridViewReservation.TabIndex = 0;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Reservation_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Reservation_Room_Type";
            this.Column2.HeaderText = "Oda Tipi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Reservation_Room_Number";
            this.Column3.HeaderText = "Oda No.";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Reservation_Client_ID";
            this.Column4.HeaderText = "Müşteri ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Reservation_In";
            this.Column5.HeaderText = "Giriş";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Reservation_Out";
            this.Column6.HeaderText = "Çıkış";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // textBoxSearchClientID
            // 
            this.textBoxSearchClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchClientID.Location = new System.Drawing.Point(96, 122);
            this.textBoxSearchClientID.Name = "textBoxSearchClientID";
            this.textBoxSearchClientID.Size = new System.Drawing.Size(319, 28);
            this.textBoxSearchClientID.TabIndex = 1;
            this.textBoxSearchClientID.TextChanged += new System.EventHandler(this.textBoxSearchClientID_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(92, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Müşteri Adı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.BlueViolet;
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Müşteri Ara:";
            // 
            // tabPageUpdateAndCancelReservation
            // 
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.dateTimePickerOut1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.dateTimePickerIn1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.comboBoxNo1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.buttonCancel);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label7);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.textBoxClientID1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label8);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label9);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label10);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label11);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label12);
            this.tabPageUpdateAndCancelReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndCancelReservation.Name = "tabPageUpdateAndCancelReservation";
            this.tabPageUpdateAndCancelReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndCancelReservation.Size = new System.Drawing.Size(1094, 428);
            this.tabPageUpdateAndCancelReservation.TabIndex = 2;
            this.tabPageUpdateAndCancelReservation.Text = "Rezervasyon Güncelle ve İptal et";
            this.tabPageUpdateAndCancelReservation.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndCancelReservation.Click += new System.EventHandler(this.tabPageUpdateAndCancelReservation_Click);
            this.tabPageUpdateAndCancelReservation.Leave += new System.EventHandler(this.tabPageUpdateAndCancelReservation_Leave);
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut1.Location = new System.Drawing.Point(615, 258);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(264, 28);
            this.dateTimePickerOut1.TabIndex = 5;
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn1.Location = new System.Drawing.Point(263, 258);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(264, 28);
            this.dateTimePickerIn1.TabIndex = 4;
            // 
            // comboBoxNo1
            // 
            this.comboBoxNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo1.FormattingEnabled = true;
            this.comboBoxNo1.Items.AddRange(new object[] {
            "Lütfen seçim yapın.."});
            this.comboBoxNo1.Location = new System.Drawing.Point(615, 103);
            this.comboBoxNo1.Name = "comboBoxNo1";
            this.comboBoxNo1.Size = new System.Drawing.Size(238, 29);
            this.comboBoxNo1.TabIndex = 2;
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Lütfen seçim yapın..",
            "Tek",
            "Çift",
            "Aile",
            "Suit"});
            this.comboBoxType1.Location = new System.Drawing.Point(263, 103);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(238, 29);
            this.comboBoxType1.TabIndex = 1;
            this.comboBoxType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxType1_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(386, 312);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 46);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Sil";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(263, 312);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(115, 46);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(611, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Oda No.:";
            // 
            // textBoxClientID1
            // 
            this.textBoxClientID1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID1.Location = new System.Drawing.Point(263, 184);
            this.textBoxClientID1.Name = "textBoxClientID1";
            this.textBoxClientID1.Size = new System.Drawing.Size(238, 28);
            this.textBoxClientID1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(611, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Çıkış:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(259, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giriş:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(259, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Müşteri No:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(259, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Oda Tipi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkViolet;
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Rezervasyon Güncelle ve Sil:";
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReservation);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.Leave += new System.EventHandler(this.UserControlReservation_Leave);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchReservation.ResumeLayout(false);
            this.tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tabPageUpdateAndCancelReservation.ResumeLayout(false);
            this.tabPageUpdateAndCancelReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.TabPage tabPageSearchReservation;
        private System.Windows.Forms.TabPage tabPageUpdateAndCancelReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox comboBoxNo;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.ComboBox comboBoxNo1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxClientID1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox textBoxSearchClientID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
