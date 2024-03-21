namespace TutorCA2Net104.Models
{
    public class Sanpham
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } 
        public decimal Stock { get; set;} // SL Tồn
        public int Status { get; set; }
        public virtual ICollection<HoaDonChitiet> HoaDonChitiets { get; set; }
    }
}
