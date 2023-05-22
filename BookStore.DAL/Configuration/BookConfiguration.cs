using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configuration;

public class BookConfiguration : BaseConfiguration<Book>
{
    public override void Configure(EntityTypeBuilder<Book> builder)
    {
        base.Configure(builder);

        builder.ToTable("book");

        builder.Property(x => x.Name)
            .HasMaxLength(256);

        builder.Property(x => x.Description)
            .HasMaxLength(256);

        builder.Property(x => x.Title)
            .HasMaxLength(256);
    }
}