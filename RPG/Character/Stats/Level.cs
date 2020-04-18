using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    class Level
    {
        private int _value;
        private int _experience;
        private int _nextLevel;

        public Level()
        {
            _value = 1;
            _experience = 0;
            CalculateNextLevel();
        }

        public void AddExperience(int amount)
        {
            if (amount >= 0)
            {
                _experience += amount;

                if (_experience >= _nextLevel)
                {
                    _value++;
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

        public int GetValue()
        {
            return _value;
        }

        public int GetExperience()
        {
            return _experience;
        }

        private void CalculateNextLevel()
        {
            _nextLevel = _value * 50;
        }
    }
}
