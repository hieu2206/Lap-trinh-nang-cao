using QuanLySinhVien.Data.DAL;
using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.BUL
{
    public class LopHocBUL
    {
        private readonly LopHocDAL lhd;

        public LopHocBUL()
        {
            lhd = new LopHocDAL();
        }

        public List<LopHoc> GetAllLopHoc()
        {
            return lhd.GetAllLopHoc();
        }

        public LopHoc? GetLopHocByMa(string maLop)
        {
            return lhd.GetLopHocByMa(maLop);
        }
    }
}
