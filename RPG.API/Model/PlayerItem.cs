using System;

namespace RPG.API.Model
{
    public class PlayerItem
    {
        public int Id { get; set; }
        public Guid PlayerItemId { get; set; }
        public int PlayerId { get; set; }
        public int ItemId { get; set; }
        public bool IsEquipped { get; set; }
        public Player Player { get; set; }
        public Item Item { get; set; }
        public Guid PlayerGuid { get; set; }
        public Guid ItemGuid { get; set; }

        public PlayerItem(int playerId, int itemId, bool isEquiped, Guid playerGuid, Guid itemGuid)
        {
            PlayerItemId = Guid.NewGuid();
            PlayerId = playerId;
            ItemId = itemId;
            IsEquipped = isEquiped;
            PlayerGuid = playerGuid;
            ItemGuid = itemGuid;
        }
    }
}
