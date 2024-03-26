using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorCA2Net104.Models;

namespace TutorCA2Net104.Configurations
{
    public class SanPhamConfig : IEntityTypeConfiguration<Sanpham>
    {
        public void Configure(EntityTypeBuilder<Sanpham> builder)
        {
            // Cấu hình tên bảng
            builder.ToTable("Sản phẩm");
            // Cấu hình thuộc tính
            builder.HasKey(x => x.Id); // Khóa chính
            // builder.HasKey(x=> new { x.Id, x.Name }); // Khóa Composite - nhiều cột
            builder.Property(x => x.Name).IsRequired().HasColumnName("Tên SP");
            builder.Property(x=>x.Description).IsRequired().HasColumnType("nvarchar(100)");

        }
    }
}
