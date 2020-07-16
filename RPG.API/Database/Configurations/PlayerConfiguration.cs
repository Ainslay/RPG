using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPG.API.Model;

namespace RPG.API.Database.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.PlayerId).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Proffesion).IsRequired().HasConversion(new EnumToStringConverter<Proffesions>());
            builder.HasMany(p => p.Items).WithOne(i => i.Player).IsRequired();
        }
    }
}
