using System;

namespace RPG.API.Model
{
    public class PlayerItem
    {
        public int Id { get; set; }
        public Guid PlayerItemId { get; set; }
        public int PlayerId { get; set; }
        public int ItemId { get; set; }
        public bool IsEquiped { get; set; }
        public Player Player { get; set; }
        public Item Item { get; set; }
        public Guid PlayerGuid { get; set; }
        public Guid ItemGuid { get; set; }
    }
}
