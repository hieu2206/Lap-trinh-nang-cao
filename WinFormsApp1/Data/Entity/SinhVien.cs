using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Data.Entity
{
    /// <summary>
    /// Entity: chỉ mô tả dữ liệu sinh viên (phía n của quan hệ 1 lớp - n sinh viên).
    /// </summary>
    public class SinhVien : IValidatableObject
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        public string MaSV { get; set; } = string.Empty;

        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string HoTen { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9}$",
            ErrorMessage = "Số điện thoại phải gồm 10 số và bắt đầu bằng 0")]
        public string DienThoai { get; set; } = string.Empty;

        [Range(0, 10, ErrorMessage = "Điểm phải nằm trong khoảng từ 0 đến 10")]
        public double Diem { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        public string GioiTinh { get; set; } = "Nam";

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public string TrangThai { get; set; } = "Đang học";

        [Required(ErrorMessage = "Lớp học không được để trống")]
        public string MaLop { get; set; } = string.Empty;

        public string TenLop { get; set; } = string.Empty;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (NgaySinh > DateTime.Today.AddYears(-18))
            {
                yield return new ValidationResult(
                    "Sinh viên phải đủ 18 tuổi",
                    new[] { nameof(NgaySinh) });
            }
        }

        /// <summary>
        /// Trả về danh sách lỗi. Count == 0 nghĩa là hợp lệ (đúng tên hàm mẫu giáo viên).
        /// </summary>
        public List<ValidationResult> IsInValid()
        {
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(this, new ValidationContext(this), results, true);
            return results;
        }
    }
}
