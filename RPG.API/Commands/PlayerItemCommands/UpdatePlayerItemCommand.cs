using System;
using MediatR;

namespace RPG.API.Commands.PlayerItemCommands
{
    public class UpdatePlayerItemCommand : IRequest
    {
        public Guid PlayerItemGuid { get; set; }
        public bool IsEquipped { get; set; }
    }
}
