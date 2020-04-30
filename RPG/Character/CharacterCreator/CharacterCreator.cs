using System;
using System.Collections.Generic;
using System.Text;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Input;
using RPG.Input.Result;

namespace RPG.Character.CharacterCreator
{
    class CharacterCreator
    {
        public PlayerCharacter Create()
        {
            var name = GetNameInput();
            var proffesion = GetProffesionInput();
            return PlayerFactory.Create(name, proffesion);
        }

        private PlayerProffesions GetProffesionInput()
        {
            var playerInput = new CharacterCreatorInput();
            InputResult<PlayerProffesions> inputResult;
            do
            {
                inputResult = playerInput.GetInput();
            }
            while (!inputResult.IsValid());

            return inputResult.GetValidInput();
        }

        private string GetNameInput()
        {
            string name; 

            do
            {
                Console.WriteLine("Please state a name of your character: ");
                name = Console.ReadLine();
                Console.Clear();
            }
            while (string.IsNullOrWhiteSpace(name));

            return name.Trim();
        }
    }
}
