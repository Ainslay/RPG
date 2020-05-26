using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Model;

namespace RPG.API.Commands
{
    public class UpdateItemCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FlavorText { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
        public int BonusStrength { get; set; }
        public int BonusDexterity { get; set; }
        public int BonusIntelligence { get; set; }
        public ItemTypes Type { get; set; }
    }
}
