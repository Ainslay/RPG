using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character
{
    class Player : BaseEntity
    {
        private Proffesion _proffesion;

        public Player(string name, Proffesion proffesion) : base(name)
        {

        }
    }
}
