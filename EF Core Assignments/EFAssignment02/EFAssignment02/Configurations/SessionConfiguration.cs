using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EFAssignment02.Models;

public class SessionConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Title).IsRequired();
        builder.Property(s => s.Description).IsRequired();

        builder.HasOne(s => s.Event)
            .WithMany(e => e.Sessions)
            .HasForeignKey(s => s.EventId);
    }
}