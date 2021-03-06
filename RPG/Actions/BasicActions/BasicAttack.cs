﻿using System;
using RPG.Character;
using RPG.Utilities;

namespace RPG.Actions
{
    class BasicAttack : Action, IAction
    {
        private readonly BaseCharacter _attacker;
        private readonly BaseCharacter _target;

        public BasicAttack(BaseCharacter attacker, BaseCharacter target)
        {
            ParamCheck.IsNull(attacker);
            ParamCheck.IsNull(target);

            _attacker = attacker;
            _target = target;
        }

        public void Execute()
        {
            IsAlreadyExecuted();

            var damage = _attacker.GetStatistics().GetPhysicalAttack();
            _target.TakeDamage(damage);
            Console.WriteLine($"{_attacker.GetName()} inflicted {damage} damage to {_target.GetName()}");
            Executed = true;
        }
    }
}
