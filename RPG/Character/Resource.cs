using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character
{
    abstract class Resource
    {
        public string Name { get; private set; }
        public uint BaseAmount { get; private set; }
        private uint _actualAmount;

        public Resource(string name, uint baseAmount)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            BaseAmount = baseAmount;
            _actualAmount = baseAmount;
        }

        public abstract void Generate();
        public abstract bool Spend(uint amount);
    }
}
