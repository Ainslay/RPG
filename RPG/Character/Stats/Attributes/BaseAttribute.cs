namespace RPG.Character.Stats
{
    abstract class BaseAttribute : IAttribute
    {
        private int _value;

        public BaseAttribute(int value)
        {
            _value = value;
        }

        public virtual int GetValue()
        {
            return _value;
        }
    }
}
