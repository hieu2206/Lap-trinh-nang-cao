namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errPMaSV = new ErrorProvider(components);
            erpHoten = new ErrorProvider(components);
            erpEmail = new ErrorProvider(components);
            erpDienThoai = new ErrorProvider(components);
            erpLopHoc = new ErrorProvider(components);
            erpDiem = new ErrorProvider(components);
            erpNgaySinh = new ErrorProvider(components);
            grbThongTin = new GroupBox();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiem = new DataGridViewTextBoxColumn();
            colLop = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            button6 = new Button();
            button5 = new Button();
            textBox5 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            buttonLamMoi = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonThem = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelEmail = new Label();
            LabelScore = new Label();
            cboLop = new ComboBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            textBox4 = new TextBox();
            labelGender = new Label();
            labelBorn = new Label();
            textBox2 = new TextBox();
            labelClass = new Label();
            textName = new TextBox();
            labelName = new Label();
            txtMaSV = new TextBox();
            labelMaSV = new Label();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(dgvSinhVien);
            grbThongTin.Controls.Add(button6);
            grbThongTin.Controls.Add(button5);
            grbThongTin.Controls.Add(textBox5);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(comboBox2);
            grbThongTin.Controls.Add(label3);
            grbThongTin.Controls.Add(textBox3);
            grbThongTin.Controls.Add(label2);
            grbThongTin.Controls.Add(buttonLamMoi);
            grbThongTin.Controls.Add(buttonSua);
            grbThongTin.Controls.Add(buttonXoa);
            grbThongTin.Controls.Add(buttonThem);
            grbThongTin.Controls.Add(comboBox1);
            grbThongTin.Controls.Add(label1);
            grbThongTin.Controls.Add(textPhoneNumber);
            grbThongTin.Controls.Add(labelPhoneNumber);
            grbThongTin.Controls.Add(dateTimePicker1);
            grbThongTin.Controls.Add(labelEmail);
            grbThongTin.Controls.Add(LabelScore);
            grbThongTin.Controls.Add(cboLop);
            grbThongTin.Controls.Add(radNam);
            grbThongTin.Controls.Add(radNu);
            grbThongTin.Controls.Add(textBox4);
            grbThongTin.Controls.Add(labelGender);
            grbThongTin.Controls.Add(labelBorn);
            grbThongTin.Controls.Add(textBox2);
            grbThongTin.Controls.Add(labelClass);
            grbThongTin.Controls.Add(textName);
            grbThongTin.Controls.Add(labelName);
            grbThongTin.Controls.Add(txtMaSV);
            grbThongTin.Controls.Add(labelMaSV);
            grbThongTin.Location = new Point(3, 12);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1011, 584);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông tin sinh viên.";
            grbThongTin.Enter += groupBox1_Enter;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colNgaySinh, colGioiTinh, colEmail, colDienThoai, colDiem, colLop, colTrangThai });
            dgvSinhVien.Location = new Point(1, 338);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 62;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1004, 233);
            dgvSinhVien.TabIndex = 19;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // colMaSV
            // 
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 8;
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.MinimumWidth = 8;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 8;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 8;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.HeaderText = "Điện thoại";
            colDienThoai.MinimumWidth = 8;
            colDienThoai.Name = "colDienThoai";
            colDienThoai.ReadOnly = true;
            // 
            // colDiem
            // 
            colDiem.DataPropertyName = "Diem";
            colDiem.HeaderText = "Điểm";
            colDiem.MinimumWidth = 8;
            colDiem.Name = "colDiem";
            colDiem.ReadOnly = true;
            // 
            // colLop
            // 
            colLop.DataPropertyName = "TenLop";
            colLop.HeaderText = "Lớp";
            colLop.MinimumWidth = 8;
            colLop.Name = "colLop";
            colLop.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 8;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // button6
            // 
            button6.Location = new Point(664, 283);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 18;
            button6.Text = "Hiện tất cả";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonHienTatCa_Click;
            // 
            // button5
            // 
            button5.Location = new Point(551, 283);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 17;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonTim_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(491, 286);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(54, 31);
            textBox5.TabIndex = 16;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 283);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 27;
            label4.Text = "Điểm";
            label4.Click += label4_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(316, 283);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(111, 33);
            comboBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 283);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 25;
            label3.Text = "Lớp";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 31);
            textBox3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 283);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 23;
            label2.Text = "Từ khóa";
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.Location = new Point(664, 239);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(112, 34);
            buttonLamMoi.TabIndex = 13;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = true;
            buttonLamMoi.Click += buttonLamMoi_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(433, 239);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(112, 34);
            buttonSua.TabIndex = 11;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(551, 239);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(112, 34);
            buttonXoa.TabIndex = 12;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(315, 239);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(112, 34);
            buttonThem.TabIndex = 10;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(618, 182);
            comboBox1.MaxDropDownItems = 3;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 33);
            comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 190);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 17;
            label1.Text = "Trạng thái";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(367, 184);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(142, 31);
            textPhoneNumber.TabIndex = 8;
            textPhoneNumber.TextChanged += textPhoneNumber_TextChanged;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(268, 187);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(93, 25);
            labelPhoneNumber.TabIndex = 15;
            labelPhoneNumber.Text = "Điện thoại";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(103, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(122, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(6, 181);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // LabelScore
            // 
            LabelScore.AutoSize = true;
            LabelScore.Location = new Point(535, 100);
            LabelScore.Name = "LabelScore";
            LabelScore.Size = new Size(54, 25);
            LabelScore.TabIndex = 4;
            LabelScore.Text = "Điểm";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(618, 24);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(150, 33);
            cboLop.TabIndex = 2;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(352, 98);
            radNam.Name = "radNam";
            radNam.Size = new Size(75, 29);
            radNam.TabIndex = 4;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            radNam.CheckedChanged += radNam_CheckedChanged;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(433, 98);
            radNu.Name = "radNu";
            radNu.Size = new Size(61, 29);
            radNu.TabIndex = 5;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            radNu.CheckedChanged += radNu_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(618, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(269, 100);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(78, 25);
            labelGender.TabIndex = 7;
            labelGender.Text = "Giới tính";
            // 
            // labelBorn
            // 
            labelBorn.AutoSize = true;
            labelBorn.Location = new Point(6, 100);
            labelBorn.Name = "labelBorn";
            labelBorn.Size = new Size(91, 25);
            labelBorn.TabIndex = 5;
            labelBorn.Text = "Ngày sinh";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(523, 24);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(76, 25);
            labelClass.TabIndex = 3;
            labelClass.Text = "Lớp học";
            // 
            // textName
            // 
            textName.Location = new Point(341, 24);
            textName.Name = "textName";
            textName.Size = new Size(150, 31);
            textName.TabIndex = 1;
            textName.TextChanged += textName_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(268, 24);
            labelName.Name = "labelName";
            labelName.Size = new Size(67, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Họ Tên";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(75, 24);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(150, 31);
            txtMaSV.TabIndex = 0;
            txtMaSV.Leave += txtMaSV_Leave;
            txtMaSV.KeyDown += txtMaSV_KeyDown;
            txtMaSV.Enter += txtMaSV_Enter;
            txtMaSV.TextChanged += txtMaSV_TextChanged;
            txtMaSV.KeyPress += txtMaSV_KeyPress;
            // 
            // labelMaSV
            // 
            labelMaSV.AutoSize = true;
            labelMaSV.Location = new Point(6, 27);
            labelMaSV.Name = "labelMaSV";
            labelMaSV.Size = new Size(63, 25);
            labelMaSV.TabIndex = 0;
            labelMaSV.Text = "Mã SV";
            // 
            // Form1
            // 
            errPMaSV.ContainerControl = this;
            erpHoten.ContainerControl = this;
            erpEmail.ContainerControl = this;
            erpDienThoai.ContainerControl = this;
            erpLopHoc.ContainerControl = this;
            erpDiem.ContainerControl = this;
            erpNgaySinh.ContainerControl = this;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 612);
            Controls.Add(grbThongTin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbThongTin;
        private TextBox txtMaSV;
        private Label labelMaSV;
        private RadioButton radNu;
        private TextBox textBox4;
        private Label labelGender;
        private Label labelBorn;
        private TextBox textBox2;
        private Label labelClass;
        private TextBox textName;
        private Label labelName;
        private RadioButton radNam;
        private ComboBox cboLop;
        private Label LabelScore;
        private Label labelEmail;
        private Label labelPhoneNumber;
        private DateTimePicker dateTimePicker1;
        private TextBox textPhoneNumber;
        private ComboBox comboBox1;
        private Label label1;
        private Button buttonLamMoi;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonThem;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private Button button5;
        private TextBox textBox5;
        private Button button6;
        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiem;
        private DataGridViewTextBoxColumn colLop;
        private DataGridViewTextBoxColumn colTrangThai;
        private ErrorProvider errPMaSV;
        private ErrorProvider erpHoten;
        private ErrorProvider erpEmail;
        private ErrorProvider erpDienThoai;
        private ErrorProvider erpLopHoc;
        private ErrorProvider erpDiem;
        private ErrorProvider erpNgaySinh;
    }
}
