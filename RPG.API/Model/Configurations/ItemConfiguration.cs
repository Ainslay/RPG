using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RPG.API.Model.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Name).IsRequired().HasMaxLength(50);
            builder.Property(item => item.FlavorText).HasMaxLength(300);
            builder.Property(item => item.Type).HasConversion(new EnumToStringConverter<ItemTypes>());
        }
    }
}
