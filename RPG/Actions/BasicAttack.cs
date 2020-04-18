using System;
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

        public void Perform()
        {
            IsAlreadyExecuted();

            var damage = _attacker.GetStatistics().AttackStrength.Physical;
            _target.TakeDamage(damage);
            Console.WriteLine($"{_attacker.Name} inflicted {damage} damage to {_target.Name}");
            _executed = true;
        }
    }
}
