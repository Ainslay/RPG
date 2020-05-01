namespace RPG.Character.Stats
{
    abstract class BaseAttribute : IAttribute, IRestorable
    {
        private int _baseValue;
        private int _currentValue;

        public BaseAttribute(int baseValue)
        {
            _baseValue = baseValue;
            _currentValue = baseValue;
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
