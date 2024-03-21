using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorCA2Net104.Models;

namespace TutorCA2Net104.Configurations
{
    public class HoaDonChiTietConfig : IEntityTypeConfiguration<HoaDonChitiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChitiet> builder)
        {
            builder.HasKey(x => x.Id);
            // builder.HasAlternateKey(x => x.Id);
            // Khóa ngoại
            builder.HasOne(p => p.HoaDon).WithMany(p => p.HoaDonChitiets)
                .HasForeignKey(p => p.IdHD).HasConstraintName("FK_HD_HDCT");
                
        }
    }
}
