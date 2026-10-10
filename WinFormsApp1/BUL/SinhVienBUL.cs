using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using QuanLySinhVien.Data.DAL;
using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.BUL
{
    public class SinhVienBUL
    {
        private readonly SinhVienDAL svd;
        private readonly LopHocDAL lhd;

        public SinhVienBUL()
        {
            svd = new SinhVienDAL();
            lhd = new LopHocDAL();
        }

        public List<SinhVien> GetAllSinhVien()
        {
            var ds = svd.GetAllSinhVien();
            foreach (var sv in ds)
                GanTenLop(sv);
            return ds;
        }

        public SinhVien? GetSinhVienByMaSV(string maSV)
        {
            var sv = svd.GetSinhVienByMaSV(maSV);
            if (sv != null)
                GanTenLop(sv);
            return sv;
        }

        public List<SinhVien> GetSinhVienByMaLop(string maLop)
        {
            var ds = svd.GetSinhViensByMaLop(maLop);
            foreach (var sv in ds)
                GanTenLop(sv);
            return ds;
        }

        public List<SinhVien> TimKiem(string tuKhoa, string? maLop, double diemTu)
        {
            return GetAllSinhVien().Where(sv =>
            {
                bool khopTuKhoa = string.IsNullOrWhiteSpace(tuKhoa)
                    || sv.MaSV.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    || sv.HoTen.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    || sv.Email.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    || sv.DienThoai.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase);

                bool khopLop = string.IsNullOrEmpty(maLop) || sv.MaLop == maLop;
                bool khopDiem = sv.Diem >= diemTu;
                return khopTuKhoa && khopLop && khopDiem;
            }).ToList();
        }

        public void AddSinhVien(SinhVien sv)
        {
            List<ValidationResult> vdr = sv.IsInValid();
            if (vdr.Count > 0)
            {
                throw new Exception(string.Join(Environment.NewLine,
                    vdr.Select(vr => vr.ErrorMessage)));
            }

            var daCo = svd.GetSinhVienByMaSV(sv.MaSV);
            if (daCo != null)
            {
                throw new Exception("Mã sinh viên đã tồn tại");
            }

            ChuanHoa(sv);
            GanTenLop(sv);

            try
            {
                svd.AddSinhVien(sv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sinh viên: " + ex.Message);
            }
        }

        public void UpdateSinhVien(SinhVien sv)
        {
            var validationResults = sv.IsInValid();
            if (validationResults.Count > 0)
            {
                throw new Exception(string.Join(Environment.NewLine,
                    validationResults.Select(vr => vr.ErrorMessage)));
            }

            if (svd.GetSinhVienByMaSV(sv.MaSV) == null)
            {
                throw new Exception("Không tìm thấy sinh viên để sửa.");
            }

            ChuanHoa(sv);
            GanTenLop(sv);

            try
            {
                svd.UpdateSinhVien(sv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật sinh viên: " + ex.Message);
            }
        }

        public void DeleteSinhVien(string maSV)
        {
            if (svd.GetSinhVienByMaSV(maSV) == null)
            {
                throw new Exception("Không tìm thấy sinh viên để xóa.");
            }

            try
            {
                svd.DeleteSinhVien(maSV);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sinh viên: " + ex.Message);
            }
        }

        private void ChuanHoa(SinhVien sv)
        {
            sv.HoTen = sv.HoTen.Trim();
            sv.HoTen = Regex.Replace(sv.HoTen, @"\s+", " ");
            sv.MaSV = sv.MaSV.Trim();
            sv.Email = sv.Email.Trim();
            sv.DienThoai = sv.DienThoai.Trim();
        }

        private void GanTenLop(SinhVien sv)
        {
            sv.TenLop = lhd.GetLopHocByMa(sv.MaLop)?.TenLop ?? sv.MaLop;
        }
    }
}
