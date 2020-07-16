using System;
using System.ComponentModel.DataAnnotations;
using MediatR;
using RPG.API.Model;

namespace RPG.API.Commands.PlayerCommands
{
    public class AddPlayerCommand : IRequest
    {
        public string Name { get; set; }
        public Proffesions Proffesion { get; set; }
        [Range(1, 99)]
        public int Level { get; set; }
        public int Experience { get; set; }
        [Range(1, 999)]
        public int Strength { get; set; }
        [Range(1, 999)]
        public int Dexterity { get; set; }
        [Range(1, 999)]
        public int Intelligence { get; set; }
    }
}
