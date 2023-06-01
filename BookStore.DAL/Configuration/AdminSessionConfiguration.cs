using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configuration;

public class AdminSessionConfiguration : BaseConfiguration<AdminSession>
{
    public override void Configure(EntityTypeBuilder<AdminSession> builder)
    {
        base.Configure(builder);


        builder.ToTable("admin_session");

        builder.Property(x => x.Token)
            .HasMaxLength(512)
            .IsRequired();

    }
}