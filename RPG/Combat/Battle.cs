using RPG.Character;
using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Combat
{
    class Battle
    {
        private Player _player;
        private Enemy _enemy;
        private List<BaseCharacter> _fighters;

        public Battle(Player player, Enemy enemy)
        {
            ParamCheck.IsNull(player);
            ParamCheck.IsNull(enemy);
            
            _player = player;
            _enemy = enemy;
            _fighters = new List<BaseCharacter> { player, enemy };
        }

        public void Fight()
        {
            while (StillFighting())
            {
                var turns = TurnManager.Build(_fighters);

                foreach (var turn in turns.ToList())
                {
                    if(turn.GetCharacter().Equals(_player))
                    {
                        _player.Attack(_enemy);
                    }
                    else
                    {
                        turn.GetCharacter().Attack(_player);
                    }

                    TurnManager.Remove();
                }
            }

            System.Console.WriteLine("Battle has ended.");
        }

        private bool StillFighting()
        {
            return _player.IsAlive() && _enemy.IsAlive();
        }
    }
}
