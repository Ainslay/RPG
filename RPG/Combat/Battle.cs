using System.Collections.Generic;
using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Utilities;

namespace RPG.Combat
{
    class Battle
    {
        private Player _player;
        private List<Enemy> _enemies;
        private int _turn;
        
        public Battle(Player player, List<Enemy> enemies)
        {
            ParamCheck.IsNull(player);
            ParamCheck.IsNullOrEmpty(enemies);

            _player = player;
            _enemies = enemies;
            _turn = 1;
        }

        public void Fight()
        {
            while (_player.IsAlive && _enemies.Exists(enemy => enemy.IsAlive))
            {
                // pętla walki

                // input od użytkownika

                // zadanie obrażeń i rekalkulacja statystyk
            }
        }
    }
}
