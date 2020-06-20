using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPG.API.Model.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Health).IsRequired();
            builder.Property(p => p.Resource).IsRequired();
            builder.Property(p => p.Strength).IsRequired();
            builder.Property(p => p.Dexterity).IsRequired();
            builder.Property(p => p.Intelligence).IsRequired();
            builder.Property(p => p.Level).IsRequired();
            builder.HasMany(p => p.Items).WithOne(i => i.Player).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
