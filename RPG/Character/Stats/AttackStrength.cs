using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    class AttackStrength
    {
        public uint Physical { get; private set; }
        public uint Magic { get; private set; }

        public AttackStrength()
        {
            Calculate();
        }

        public void Calculate()
        {

        }
    }
}
