using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPG.API.Model;

namespace RPG.API.Database.Configurations
{
    public class PlayerItemConfiguration : IEntityTypeConfiguration<PlayerItem>
    {
        public void Configure(EntityTypeBuilder<PlayerItem> builder)
        {
            builder.ToTable("PlayerItems");
            builder.HasKey(i => i.PlayerItemId);
            builder.Property(i => i.PlayerId).IsRequired();
            builder.Property(i => i.ItemId).IsRequired();
            builder.Property(i => i.IsEquiped).IsRequired();
        }
    }
}
