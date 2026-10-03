using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Models
{
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        public string MaSV { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9}$",
            ErrorMessage = "Số điện thoại phải gồm 10 số")]
        public string DienThoai { get; set; }

        [Range(0, 10,
            ErrorMessage = "Điểm phải nằm trong khoảng từ 0 đến 10")]
        public double Diem { get; set; }

        public DateTime NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public string TrangThai { get; set; }

        public string MaLop { get; set; }

        public IEnumerable<ValidationResult> Validate(
    ValidationContext validationContext)
        {
            if (NgaySinh > DateTime.Now.AddYears(-18))
            {
                yield return new ValidationResult(
                    "Sinh viên phải đủ 18 tuổi");
            }
        }
    }

}