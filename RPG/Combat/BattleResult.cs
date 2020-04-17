using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Utilities;
using System;

namespace RPG.Combat
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
            if(!_fled)
            {
                if (IsPlayerVictory())
                {
                    var expToGain = ExperienceToGain();
                    _player.AddExperience(expToGain);

                    Console.WriteLine("The battle is won, you get to live another day.\n");
                    Console.WriteLine("Your status:");
                    _player.PrintStatus();
                    Console.WriteLine("You gained {0} experience.", expToGain);
                }
                else
                {
                    var expToLose = ExperienceToLose();
                    _player.SubstractExperience(expToLose);

                    Console.WriteLine("You have been bested by {0}.\n", _enemy.Name);
                    Console.WriteLine("Your status:");
                    _player.PrintStatus();
                    Console.WriteLine("You lost {0} experience.", expToLose);
                }
            }
            else
            {
                Console.WriteLine("You fled and therefore you gain no rewards for that battle.");
            }
            
            _player.RestoreStatus();
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
