using System;

using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Utilities;

namespace RPG.Combat.Battles
{
    class BattleResult
    {
        private readonly PlayerCharacter _player;
        private readonly Enemy _enemy;
        private readonly bool _fled;

        public BattleResult(Battle battle)
        {
            ParamCheck.IsNull(battle);

            _player = battle.GetPlayer();
            _enemy = battle.GetEnemy();
            _fled = battle.GetFled();
        }

        public void Resolve()
        {
            if (HasFled())
            {
                Console.WriteLine("You fled and therefore you gain no rewards for that battle.");
            }
            else
            {
                if (IsPlayerVictory())
                {
                    Victory();
                }
                else
                {
                    Defeat();
                }
            }

            _player.RestoreStatus();
        }

        private void Victory()
        {
            var expToGain = ExperienceToGain();
            _player.AddExperience(expToGain);

            Console.WriteLine("The battle is won, you get to live another day.\n");
            Console.WriteLine("Your status:");
            _player.PrintStatus();
            Console.WriteLine("You gained {0} experience.", expToGain);
        }

        private void Defeat()
        {
            var expToLose = ExperienceToLose();
            _player.SubstractExperience(expToLose);

            Console.WriteLine("You have been bested by {0}.\n", _enemy.Name);
            Console.WriteLine("Your status:");
            _player.PrintStatus();
            Console.WriteLine("You lost {0} experience.", expToLose);
        }

        private bool HasFled()
        {
            return _fled;
        }

        private int ExperienceToGain()
        {
            return (int)_enemy.GetThreatLevel() * _player.GetLevel() * 10;
        }

        private int ExperienceToLose()
        {
            return (int)_enemy.GetThreatLevel() * _player.GetLevel() * 4;
        }

        private bool IsPlayerVictory()
        {
            return _player.IsAlive();
        }
    }
}
