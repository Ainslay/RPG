using System;

namespace RPG.API.DTOs
{
    public class PlayerItemDTO
    {
        public Guid ItemGuid { get; set; }
        public bool IsEquiped { get; set; }
    }
}
