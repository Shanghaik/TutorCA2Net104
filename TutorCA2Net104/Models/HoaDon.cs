namespace TutorCA2Net104.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public DateTime SellDate { get; set; } // Thời điểm bán
        public Decimal Total  { get; set; }
        public Guid IdKhachHang { get; set; }
        public int Status { get; set; } 
        // Tạo navigation để thiết lập quan hệ
        public virtual KhachHang KhachHang { get; set;} 
        public virtual ICollection<HoaDonChitiet> HoaDonChitiets { get; set;}
    }
}
