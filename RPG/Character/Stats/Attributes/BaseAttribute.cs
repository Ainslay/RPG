using RPG.Utilities;

namespace RPG.Character.Stats
{
    abstract class BaseAttribute : IAttribute, IRestorable
    {
        private int _baseValue;
        private int _currentValue;

        public BaseAttribute(int baseValue)
        {
            ParamCheck.IsBelowZero(baseValue);

            _baseValue = baseValue;
            _currentValue = baseValue;
        }

        public void Increase()
        {
            _baseValue += 1;
            // TODO: Recalculate() _currentValue;
        }

        public virtual int GetBaseValue()
        {
            return _baseValue;
        }

        public int GetCurrentValue()
        {
            return _currentValue;
        }

        public void RestoreBaseValue()
        {
            _currentValue = _baseValue;
        }
    }
}
