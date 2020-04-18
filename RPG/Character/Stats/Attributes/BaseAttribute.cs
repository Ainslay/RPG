namespace RPG.Character.Stats
{
    abstract class BaseAttribute
    {
        private int _value;

        public BaseAttribute(int value)
        {
            _value = value;
        }

        public void Add()
        {
            _value++;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
