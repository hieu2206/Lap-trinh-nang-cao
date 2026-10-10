using System.ComponentModel.DataAnnotations;
using QuanLySinhVien.BUL;
using QuanLySinhVien.Data.Entity;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly SinhVienBUL svb = new();
        private readonly LopHocBUL lopBus = new();
        private List<SinhVien> sinhViens = new();
        private List<LopHoc> lopHocs = new();
        private bool dangNapCombo;

        public Form1()
        {
            InitializeComponent();
        }

        private void TogAdd(bool isAdding)
        {
            buttonThem.Enabled = isAdding;
            buttonXoa.Enabled = !isAdding;
            buttonSua.Enabled = !isAdding;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp" });
            comboBox1.SelectedIndex = 0;

            lopHocs = lopBus.GetAllLopHoc();
            NapComboLop();
            TogAdd(true);
            txtMaSV.Focus();
        }

        private void NapComboLop()
        {
            dangNapCombo = true;

            cboLop.DataSource = null;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = lopHocs.ToList();

            var dsLoc = new List<LopHoc> { new LopHoc { MaLop = "", TenLop = "Tất cả lớp" } };
            dsLoc.AddRange(lopHocs);
            comboBox2.DataSource = null;
            comboBox2.DisplayMember = "TenLop";
            comboBox2.ValueMember = "MaLop";
            comboBox2.DataSource = dsLoc;

            dangNapCombo = false;
            NapSinhVienTheoLopTuCsdl();
        }

        /// <summary>Tìm kiếm phía cơ sở dữ liệu: DAL lọc theo mã lớp.</summary>
        private void NapSinhVienTheoLopTuCsdl()
        {
            if (cboLop.SelectedValue is not string maLop || string.IsNullOrEmpty(maLop))
                return;

            sinhViens = svb.GetSinhVienByMaLop(maLop);
            HienThiDanhSach(sinhViens);
        }

        private void HienThiDanhSach(IEnumerable<SinhVien> danhSach)
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = danhSach.ToList();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangNapCombo)
                return;
            NapSinhVienTheoLopTuCsdl();
        }

        private void txtMaSV_Enter(object sender, EventArgs e)
        {
            txtMaSV.SelectAll();
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                dateTimePicker1.Focus();
            }
        }

        private void txtMaSV_Leave(object sender, EventArgs e)
        {
            XuLyNhapMaSinhVien();
        }

        private void txtMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                XuLyNhapMaSinhVien();
            }
        }

        private void XuLyNhapMaSinhVien()
        {
            string ma = txtMaSV.Text.Trim();
            if (string.IsNullOrWhiteSpace(ma))
                return;

            var sv = svb.GetSinhVienByMaSV(ma);
            if (sv == null)
            {
                textName.Text = "";
                textBox2.Text = "";
                textPhoneNumber.Text = "";
                textBox4.Text = "";
                radNam.Checked = true;
                TogAdd(true);
            }
            else
            {
                DoLenForm(sv);
                TogAdd(false);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVien sv)
            {
                DoLenForm(sv);
                TogAdd(false);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ClearErrorProviders();
            SinhVien sv = DocSinhVienTuForm();
            if (!HienThiLoiNeuCo(sv.IsInValid()))
                return;

            try
            {
                svb.AddSinhVien(sv);
                NapSinhVienTheoLopTuCsdl();
                MessageBox.Show("Thêm sinh viên thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
            }
            catch (Exception ex)
            {
                errPMaSV.SetError(txtMaSV, ex.Message);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            ClearErrorProviders();
            if (!XacNhan("Bạn có chắc muốn sửa thông tin sinh viên này?"))
                return;

            SinhVien sv = DocSinhVienTuForm();
            if (!HienThiLoiNeuCo(sv.IsInValid()))
                return;

            try
            {
                svb.UpdateSinhVien(sv);
                NapSinhVienTheoLopTuCsdl();
                MessageBox.Show("Cập nhật thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            ClearErrorProviders();
            if (!XacNhan("Bạn có chắc muốn xóa sinh viên này? Thao tác không hoàn tác được."))
                return;

            try
            {
                svb.DeleteSinhVien(txtMaSV.Text.Trim());
                NapSinhVienTheoLopTuCsdl();
                MessageBox.Show("Đã xóa sinh viên.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
            }
            catch (Exception ex)
            {
                errPMaSV.SetError(txtMaSV, ex.Message);
            }
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        /// <summary>Tìm kiếm trên giao diện: lọc list đang có, không gọi DAL.</summary>
        private void buttonTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = textBox3.Text.Trim();
            string? maLopLoc = comboBox2.SelectedValue as string;
            double.TryParse(textBox5.Text.Trim(), out double diemTu);

            var ketQua = sinhViens.Where(sv =>
            {
                bool khopTuKhoa = string.IsNullOrWhiteSpace(tuKhoa)
                    || sv.MaSV.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    || sv.HoTen.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    || sv.Email.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    || sv.DienThoai.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase);

                bool khopLop = string.IsNullOrEmpty(maLopLoc) || sv.MaLop == maLopLoc;
                bool khopDiem = sv.Diem >= diemTu;
                return khopTuKhoa && khopLop && khopDiem;
            });

            HienThiDanhSach(ketQua);
        }

        /// <summary>Lấy lại toàn bộ từ nguồn dữ liệu (phía CSDL).</summary>
        private void buttonHienTatCa_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox5.Clear();
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
            sinhViens = svb.GetAllSinhVien();
            HienThiDanhSach(sinhViens);
        }

        private SinhVien DocSinhVienTuForm()
        {
            double.TryParse(textBox4.Text.Trim(), out double diem);
            string maLop = cboLop.SelectedValue as string ?? "";

            return new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = textName.Text.Trim(),
                NgaySinh = dateTimePicker1.Value.Date,
                GioiTinh = radNam.Checked ? "Nam" : "Nữ",
                Email = textBox2.Text.Trim(),
                DienThoai = textPhoneNumber.Text.Trim(),
                Diem = diem,
                MaLop = maLop,
                TrangThai = comboBox1.SelectedItem?.ToString() ?? "Đang học"
            };
        }

        private void DoLenForm(SinhVien sv)
        {
            dangNapCombo = true;
            txtMaSV.Text = sv.MaSV;
            textName.Text = sv.HoTen;
            dateTimePicker1.Value = sv.NgaySinh < dateTimePicker1.MinDate
                ? DateTime.Today.AddYears(-18)
                : sv.NgaySinh;
            radNam.Checked = sv.GioiTinh == "Nam";
            radNu.Checked = sv.GioiTinh != "Nam";
            textBox2.Text = sv.Email;
            textPhoneNumber.Text = sv.DienThoai;
            textBox4.Text = sv.Diem.ToString("0.##");
            cboLop.SelectedValue = sv.MaLop;
            comboBox1.SelectedItem = sv.TrangThai;
            dangNapCombo = false;
            NapSinhVienTheoLopTuCsdl();
        }

        private void LamMoiForm()
        {
            ClearErrorProviders();
            txtMaSV.Clear();
            textName.Clear();
            textBox2.Clear();
            textPhoneNumber.Clear();
            textBox4.Clear();
            radNam.Checked = true;
            dateTimePicker1.Value = DateTime.Today.AddYears(-18);
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            TogAdd(true);
            txtMaSV.Focus();
        }

        private void ClearErrorProviders()
        {
            errPMaSV.Clear();
            erpHoten.Clear();
            erpEmail.Clear();
            erpDienThoai.Clear();
            erpLopHoc.Clear();
            erpDiem.Clear();
            erpNgaySinh.Clear();
        }

        /// <returns>true nếu không có lỗi (được phép Thêm/Sửa).</returns>
        private bool HienThiLoiNeuCo(List<ValidationResult> errors)
        {
            if (errors.Count == 0)
                return true;

            foreach (var error in errors)
            {
                if (error.MemberNames != null && error.MemberNames.Any())
                {
                    string fieldName = error.MemberNames.First();
                    switch (fieldName)
                    {
                        case "MaSV":
                            errPMaSV.SetError(txtMaSV, error.ErrorMessage);
                            break;
                        case "HoTen":
                            erpHoten.SetError(textName, error.ErrorMessage);
                            textName.Focus();
                            break;
                        case "Email":
                            erpEmail.SetError(textBox2, error.ErrorMessage);
                            textBox2.Focus();
                            break;
                        case "DienThoai":
                            erpDienThoai.SetError(textPhoneNumber, error.ErrorMessage);
                            textPhoneNumber.Focus();
                            break;
                        case "MaLop":
                            erpLopHoc.SetError(cboLop, error.ErrorMessage);
                            break;
                        case "Diem":
                            erpDiem.SetError(textBox4, error.ErrorMessage);
                            break;
                        case "NgaySinh":
                            erpNgaySinh.SetError(dateTimePicker1, error.ErrorMessage);
                            break;
                        default:
                            MessageBox.Show(error.ErrorMessage, "Lỗi dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(error.ErrorMessage, "Lỗi dữ liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        private static bool XacNhan(string noiDung)
        {
            return MessageBox.Show(noiDung, "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e) => errPMaSV.Clear();
        private void textName_TextChanged(object sender, EventArgs e) => erpHoten.Clear();
        private void textBox2_TextChanged(object sender, EventArgs e) => erpEmail.Clear();
        private void textPhoneNumber_TextChanged(object sender, EventArgs e) => erpDienThoai.Clear();
        private void textBox4_TextChanged(object sender, EventArgs e) => erpDiem.Clear();

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void radNam_CheckedChanged(object sender, EventArgs e) { }
        private void radNu_CheckedChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
