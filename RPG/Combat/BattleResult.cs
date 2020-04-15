using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Utilities;
using System;

namespace RPG.Combat
{
    class BattleResult
    {
        private PlayerCharacter _player;
        private Enemy _enemy;

        public BattleResult(PlayerCharacter player, Enemy enemy)
        {
            ParamCheck.IsNull(player);
            ParamCheck.IsNull(enemy);

            _player = player;
            _enemy = enemy;
        }

        public void Resolve()
        {
            if(IsPlayerVictory())
            {
                var expToGain = ExperienceToGain();
                _player.AddExperience(expToGain);

                Console.WriteLine("The battle is won, you get to live another day.\n");
                Console.WriteLine("Your status:");
                _player.PrintStatus();
                Console.WriteLine("\nYou gained {0} experience.", expToGain);
            }
            else
            {
                var expToLose = ExperienceToLose();
                _player.SubstractExperience(expToLose);
                
                Console.WriteLine("You have been bested by {0}.\n", _enemy.Name);
                Console.WriteLine("Your status:");
                _player.PrintStatus();
                Console.WriteLine("\nYou lost {0} experience.", expToLose);
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

        // Do poszerzenia o możliwość ucieczki, nie dopuszczam remisu (If he dies, he dies)
        private bool IsPlayerVictory()
        {
            return _player.IsAlive();
        }
    }
}
