using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Models
{
    public class LopHoc
    {
        [Required(ErrorMessage = "Mã lớp không được để trống")]
        public string MaLop { get; set; }

        [Required(ErrorMessage = "Tên lớp không được để trống")]
        public string TenLop { get; set; }

        // Quan hệ 1-n
        public List<SinhVien> SinhViens { get; set; }

        public LopHoc()
        {
            SinhViens = new List<SinhVien>();
        }
    }
}