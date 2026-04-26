using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EFAssignment02.Models;

public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
{
    public void Configure(EntityTypeBuilder<Badge> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.BadgeNumber)
            .IsRequired();

        builder.Property(b => b.IssuedDate)
            .IsRequired();

        builder.Property(b => b.Tier)
            .IsRequired();

        // One-to-One with Attendee
        builder.HasOne(b => b.Attendee)
            .WithOne(a => a.Badge)
            .HasForeignKey<Badge>(b => b.AttendeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}