namespace RPG.Character.Stats
{
    abstract class BaseAttribute
    {
        public int Value { get; private set; }

        public BaseAttribute(int value)
        {
            Value = value;
        }

        public void Add()
        {
            Value++;
        }
    }
}
