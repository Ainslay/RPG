using System;
using System.Collections.Generic;
using System.Text;

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
