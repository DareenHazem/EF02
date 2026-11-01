using EF_Core_Assignment02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment02.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BadgeNumber)
                   .IsRequired();

            builder.HasIndex(b => b.BadgeNumber)
                   .IsUnique();

            builder.Property(b => b.IssueDate)
                   .IsRequired();

            builder.Property(b => b.Tier)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.ToTable(t => t.HasCheckConstraint("CK_Badge_Tier","[Tier] IN ('Standard', 'VIP')"));

            builder.HasOne(b => b.Attendee)
                   .WithOne(a => a.Badge)
                   .HasForeignKey<Badge>(b => b.AttendeeId)
                   .IsRequired();
        }
    }
}
