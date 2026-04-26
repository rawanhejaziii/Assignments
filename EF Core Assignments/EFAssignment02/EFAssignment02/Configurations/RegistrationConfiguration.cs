using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EFAssignment02.Models;

public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
{
    public void Configure(EntityTypeBuilder<Registration> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.RegistrationDateTime)
            .IsRequired();

        builder.Property(r => r.OptionalNote)
            .HasMaxLength(500);

        // Attendee relationship
        builder.HasOne(r => r.Attendee)
            .WithMany(a => a.Registrations)
            .HasForeignKey(r => r.AttendeeId)
            .OnDelete(DeleteBehavior.Cascade);

        // Event relationship
        builder.HasOne(r => r.Event)
            .WithMany(e => e.Registrations)
            .HasForeignKey(r => r.EventId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}