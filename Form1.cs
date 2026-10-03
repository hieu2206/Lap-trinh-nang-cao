using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<LopHoc> dsLopHoc = new();
        private List<SinhVien> dsSinhVien = new();

        private void LoadLopHoc()
        {
            dsLopHoc.Add(new LopHoc()
            {
                MaLop = "L01",
                TenLop = "Kỹ thuật phần mềm"
            });

            dsLopHoc.Add(new LopHoc()
            {
                MaLop = "L02",
                TenLop = "Trí tuệ nhân tạo"
            });

            dsLopHoc.Add(new LopHoc()
            {
                MaLop = "L03",
                TenLop = "Khoa học dữ liệu"
            });

            cboLop.DataSource = dsLopHoc;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Con trỏ mặc định
            txtMaSV.Focus();

            // Trạng thái các nút
            buttonThem.Enabled = true;
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;

            // Load dữ liệu
            LoadLopHoc();
            LoadSinhVien();
        }

        private void LoadSinhVien()
        {
            dsSinhVien.Clear();

            dsSinhVien.Add(new SinhVien()
            {
                MaSV = "SV001",
                HoTen = "Nguyễn Văn An",
                GioiTinh = "Nam",
                Diem = 8.5,
                MaLop = "L01",
                Email = "an@gmail.com",
                DienThoai = "0912345678"
            });

            dsSinhVien.Add(new SinhVien()
            {
                MaSV = "SV002",
                HoTen = "Trần Thị Bình",
                GioiTinh = "Nữ",
                Diem = 9.0,
                MaLop = "L02",
                Email = "binh@gmail.com",
                DienThoai = "0987654321"
            });

            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = dsSinhVien;
        }
    }

}
