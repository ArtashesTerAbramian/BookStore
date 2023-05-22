using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configuration;

public class StoreConfiguration : BaseConfiguration<Store>
{
    public override void Configure(EntityTypeBuilder<Store> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Address)
            .HasMaxLength(256);
    }
}