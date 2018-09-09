using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Next.ECommerce.Domain.Entities;

namespace Northwind.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);

            builder.Property(e => e.UserId)
                .HasColumnName("UserID")
                .HasMaxLength(10)
                .ValueGeneratedNever();

            builder.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}