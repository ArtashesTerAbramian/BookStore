using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configuration;

public class AuthorConfiguration : BaseConfiguration<Author>
{
    public override void Configure(EntityTypeBuilder<Author> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Name)
            .HasMaxLength(256);

        builder.Property(x => x.Surname)
            .HasMaxLength(256);
    }
}