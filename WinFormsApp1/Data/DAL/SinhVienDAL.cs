using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.Data.DAL
{
    public class SinhVienDAL
    {
        private readonly List<SinhVien> sinhViens = new();

        public SinhVienDAL()
        {
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV000123",
                HoTen = "Nguyễn Văn An",
                NgaySinh = new DateTime(2006, 8, 15),
                GioiTinh = "Nam",
                Email = "an.nv@vju.ac.vn",
                DienThoai = "0912345678",
                Diem = 8.5,
                MaLop = "L01",
                TrangThai = "Đang học"
            });
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV000124",
                HoTen = "Trần Minh Anh",
                NgaySinh = new DateTime(2006, 1, 22),
                GioiTinh = "Nữ",
                Email = "anh.tm@vju.ac.vn",
                DienThoai = "0987654321",
                Diem = 9.0,
                MaLop = "L02",
                TrangThai = "Đang học"
            });
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV000125",
                HoTen = "Lê Hoàng Bình",
                NgaySinh = new DateTime(2006, 5, 9),
                GioiTinh = "Nam",
                Email = "binh.lh@vju.ac.vn",
                DienThoai = "0355556677",
                Diem = 7.4,
                MaLop = "L01",
                TrangThai = "Đang học"
            });
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV000126",
                HoTen = "Đỗ Thị Hồng",
                NgaySinh = new DateTime(2006, 11, 30),
                GioiTinh = "Nữ",
                Email = "hong.dt@vju.ac.vn",
                DienThoai = "0777888999",
                Diem = 8.1,
                MaLop = "L03",
                TrangThai = "Đang học"
            });
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return sinhViens;
        }

        public SinhVien? GetSinhVienByMaSV(string maSV)
        {
            return sinhViens.Find(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        public SinhVien? GetSinhVienById(string maSV)
        {
            return GetSinhVienByMaSV(maSV);
        }

        public List<SinhVien> GetSinhViensByMaLop(string maLop)
        {
            return sinhViens.FindAll(s => s.MaLop == maLop);
        }

        public void AddSinhVien(SinhVien sv)
        {
            sinhViens.Add(sv);
        }

        public void UpdateSinhVien(SinhVien sv)
        {
            SinhVien? sve = sinhViens.FirstOrDefault(s =>
                s.MaSV.Equals(sv.MaSV, StringComparison.OrdinalIgnoreCase));
            if (sve != null)
            {
                sve.HoTen = sv.HoTen;
                sve.NgaySinh = sv.NgaySinh;
                sve.GioiTinh = sv.GioiTinh;
                sve.MaLop = sv.MaLop;
                sve.Email = sv.Email;
                sve.DienThoai = sv.DienThoai;
                sve.Diem = sv.Diem;
                sve.TrangThai = sv.TrangThai;
                sve.TenLop = sv.TenLop;
            }
        }

        public void DeleteSinhVien(string maSV)
        {
            SinhVien? sv = GetSinhVienByMaSV(maSV);
            if (sv != null)
            {
                sinhViens.Remove(sv);
            }
        }
    }
}
