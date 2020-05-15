using RPG.Utilities;

namespace RPG.Character.Stats
{
    abstract class BaseAttribute : IAttribute, IRestorable
    {
        protected int BaseValue;
        protected int CurrentValue;

        public BaseAttribute(int baseValue)
        {
            ParamCheck.IsBelowZero(baseValue);

            BaseValue = baseValue;
            CurrentValue = baseValue;
        }

        public void Increase()
        {
            BaseValue += 1;
        }

        public virtual int GetBaseValue()
        {
            return BaseValue;
        }

        public int GetCurrentValue()
        {
            return CurrentValue;
        }

        public void RestoreBaseValue()
        {
            CurrentValue = BaseValue;
        }
    }
}
