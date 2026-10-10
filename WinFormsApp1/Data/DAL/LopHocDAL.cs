using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.Data.DAL
{
    public class LopHocDAL
    {
        private readonly List<LopHoc> lopHocs = new();

        public LopHocDAL()
        {
            lopHocs.Add(new LopHoc { MaLop = "L01", TenLop = "Kỹ thuật phần mềm 01" });
            lopHocs.Add(new LopHoc { MaLop = "L02", TenLop = "Trí tuệ nhân tạo 01" });
            lopHocs.Add(new LopHoc { MaLop = "L03", TenLop = "Khoa học dữ liệu 01" });
        }

        public List<LopHoc> GetAllLopHoc()
        {
            return lopHocs;
        }

        public LopHoc? GetLopHocByMa(string maLop)
        {
            return lopHocs.FirstOrDefault(l => l.MaLop == maLop);
        }
    }
}
