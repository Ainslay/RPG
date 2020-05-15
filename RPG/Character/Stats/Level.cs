using RPG.Utilities;

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

        public bool IsEligibleForLevelUp()
        {
            if (_experience >= _nextLevel)
            {
                _value++;
                _experience -= _nextLevel;
                CalculateNextLevel();
                return true;
            }

            return false;
        }
        
        public void AddExperience(int amount)
        {
            ParamCheck.IsBelowZero(amount);

             _experience += amount;
        }

        public void SubstractExperience(int amount)
        {
            ParamCheck.IsBelowZero(amount);

            _experience -= amount;

            if (_experience < 0)
            {
                _experience = 0;
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

        public int GetNextLevelExperience()
        {
            return _nextLevel;
        }

        private void CalculateNextLevel()
        {
            _nextLevel = _value * 30;
        }
    }
}
