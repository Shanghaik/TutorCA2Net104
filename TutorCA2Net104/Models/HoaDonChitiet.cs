namespace TutorCA2Net104.Models
{
    public class HoaDonChitiet
    {
        public Guid Id { get; set; }
        public Guid IdSp { get; set; }  
        public Guid IdHD { get; set; }
        public Decimal SellPrice { get; set; }
        public decimal SellAmount { get; set;}
        public int Status { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual Sanpham Sanpham { get; set; }

    }
}
