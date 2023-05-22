using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configuration;

public class ErrorConfiguration : BaseConfiguration<Error>
{
    public override void Configure(EntityTypeBuilder<Error> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Name)
            .HasMaxLength(256);
    }
}