using RPG.Character.Enemies;
using RPG.Character.Proffesions;
using RPG.Character.Stats;
using RPG.Input;
using RPG.Input.Result;
using RPG.Utilities;
using System;
using System.Collections.Generic;

namespace RPG.Character.Player
{
    class PlayerCharacter : BaseCharacter
    {
        public Proffesion Proffesion { get; private set; }
        private Level _level;
        
        public PlayerCharacter(string name, Proffesion proffesion)
        {
            ParamCheck.IsNullOrWhitespace(name);
            ParamCheck.IsNull(proffesion);

            Name = name;
            Proffesion = proffesion;
            Resource = proffesion.Resource;
            Attributes = proffesion.BaseAttributes;
            Health = new Health(Attributes.GetStrength());
            _level = new Level();
            Statistics = new Statistics(Attributes);
        }

        public virtual int GetLevelValue()
        {
            return _level.GetValue();
        }

        public void RestoreStatus()
        {
            var restorableStats = new List<IRestorable> { Health, Resource, Attributes, Statistics };
            restorableStats.ForEach(stat => stat.RestoreBaseValue());
            Alive = true;
        }

        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"Level: {_level.GetValue()}");
            Console.WriteLine($"Experience: {_level.GetExperience()}/{_level.GetNextLevelExperience()}\n");
        }

        public void AddExperience(int amount)
        {
            if(_level.AddExperience(amount))
            {
                LevelUp();
            }
        }

        public void SubstractExperience(int amount)
        {
            _level.SubstractExperience(amount);
        }

        private void LevelUp()
        {
            var levelUpInput = new LevelUpInput();

            int pointsToDistribute = 5;

            while(pointsToDistribute > 0)
            {
                Console.WriteLine($"Congratulations! You reached level {_level.GetValue()}!\n");

                PrintStatus();

                Console.WriteLine($"Points left: {pointsToDistribute}\n");

                var input = TryGetLevelUpInput(levelUpInput).GetValidInput();

                Attributes.Increase(input);

                pointsToDistribute--;
                Console.Clear();
            }
        }

        private InputResult<AttributesEnum> TryGetLevelUpInput(LevelUpInput levelUpInput)
        {
            InputResult<AttributesEnum> input;
            do
            {
                input = levelUpInput.GetInput();

            }
            while (!input.IsValid());

            return input;
        }
    }
}
