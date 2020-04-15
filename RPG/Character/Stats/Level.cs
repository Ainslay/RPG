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

        public int GetExperience()
        {
            return _experience;
        }

        public void AddExperience(int amount)
        {
            if (amount >= 0)
            {
                _experience += amount;

                if (_experience >= _nextLevel)
                {
                    Value++;
                    _experience -= _nextLevel;
                    CalculateNextLevel();
                }
            }
            else
            {
                throw new ArgumentException("Amount was lower than 0.");
            }
        }

        public void SubstractExperience(int amount)
        {
            if(amount >= 0)
            {
                _experience -= amount;

                if (_experience < 0)
                {
                    _experience = 0;
                }
            }
            else
            {
                throw new ArgumentException("Amount was lower than 0.");
            }
        }

        private void CalculateNextLevel()
        {
            _nextLevel = Value * 50;
        }
    }
}
