using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPG.API.Model;

namespace RPG.API.Database.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(i => i.ItemId);
            builder.Property(i => i.Name).IsRequired().HasMaxLength(50);
            builder.Property(i => i.FlavorText).HasMaxLength(500);
            builder.Property(i => i.Type).HasConversion(new EnumToStringConverter<ItemTypes>());
            builder.HasMany(i => i.PlayerItems).WithOne(pi => pi.Item).IsRequired();
        }
    }
}
