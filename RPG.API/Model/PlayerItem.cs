namespace RPG.API.Model
{
    public class PlayerItem
    {
        public int PlayerItemId { get; set; }
        public int PlayerId { get; set; }
        public int ItemId { get; set; }
        public bool IsEquiped { get; set; }
        public Player Player { get; set; }
    }
}
