using RPG.Character;
using RPG.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Combat
{
    class Turn
    {
        private BaseCharacter _character;

        public Turn(BaseCharacter character)
        {
            ParamCheck.IsNull(character);

            _character = character;
        }

        public BaseCharacter GetCharacter()
        {
            return _character;
        }
    }
}
