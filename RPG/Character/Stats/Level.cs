using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    class Level
    {
        public  int Value { get; private set; }
        private int _experience;
        private int _nextLevel;

        public Level()
        {
            Value = 1;
            _experience = 0;
            CalculateNextLevel();
        }

        public void AddExperience(int amount)
        {
            if (amount > 0)
            {
                _experience += amount;

                if (_experience >= _nextLevel)
                {
                    Value++;
                    _experience = 0;
                    CalculateNextLevel();
                }
            }
        }

        public void SubstractExperience(int amount)
        {
            if(amount > 0)
            {
                _experience -= amount;

                if (_experience < 0)
                {
                    _experience = 0;
                }
            }
        }

        private void CalculateNextLevel()
        {
            _nextLevel = Value * 50;
        }
    }
}
