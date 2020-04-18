using RPG.Character;
using RPG.Utilities;

namespace RPG.Combat.Turns
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
