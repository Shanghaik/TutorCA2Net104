using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorCA2Net104.Models;

namespace TutorCA2Net104.Configurations
{
    public class KhachHangConfig : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable(nameof(KhachHang));
            builder.HasKey(p => p.Sdt);
        }
    }
}
