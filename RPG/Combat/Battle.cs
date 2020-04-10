using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Utilities;

namespace RPG.Combat
{
    class Battle
    {
        private Player _player;
        private Enemy _enemy;
        private int _turn;
        
        public Battle(Player player)
        {
            ParamCheck.IsNull(player);

            _player = player;
            _turn = 1;

            _enemy = EnemyFactory.Create(player.Level);
        }

        public void Fight()
        {
            bool isPlayerTurn = (_player.Statistics.Iniciative.CurrentValue >= _enemy.Statistics.Iniciative.CurrentValue);

            while (_player.IsAlive && _enemy.IsAlive)
            {
                if(isPlayerTurn)
                {
                    // Działa gracz
                    _enemy.Health.TakeDamage(10);
                    isPlayerTurn = false;
                }
                else
                {
                    // Działa przeciwnik
                    _player.Health.TakeDamage(10);

                    isPlayerTurn = true;
                }

                // rekalkulacja statystyk
                _player.RecalculateStats();
                _enemy.RecalculateStats();

                _turn++;
            }
        }
    }
}
