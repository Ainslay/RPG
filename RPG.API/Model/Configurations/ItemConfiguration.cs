using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RPG.API.Model.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name).IsRequired().HasMaxLength(50);
            builder.Property(i => i.FlavorText).HasMaxLength(300);
            builder.Property(i => i.Value).IsRequired();
            builder.Property(i => i.BonusStrength).IsRequired();
            builder.Property(i => i.BonusDexterity).IsRequired();
            builder.Property(i => i.BonusIntelligence).IsRequired();
            builder.Property(i => i.Type).HasConversion(new EnumToStringConverter<ItemTypes>());
        }
    }
}
