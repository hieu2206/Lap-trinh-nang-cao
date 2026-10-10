using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Data.Entity
{
    /// <summary>
    /// Entity lớp học (phía 1 của quan hệ 1-n).
    /// </summary>
    public class LopHoc
    {
        [Required(ErrorMessage = "Mã lớp không được để trống")]
        public string MaLop { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên lớp không được để trống")]
        public string TenLop { get; set; } = string.Empty;

        public List<SinhVien> SinhViens { get; set; } = new();

        public List<ValidationResult> IsInValid()
        {
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(this, new ValidationContext(this), results, true);
            return results;
        }
    }
}
