using System;
using System.Collections.Generic;
using System.Linq;

using RPG.Actions;
using RPG.Input;
using RPG.Character;
using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Utilities;

namespace RPG.Combat
{
    partial class Battle
    {
        private PlayerCharacter _player;
        private Enemy _enemy;
        private List<BaseCharacter> _fighters;
        private bool _fled;
        private bool _stillFighting;

        public Battle(PlayerCharacter player, Enemy enemy)
        {
            ParamCheck.IsNull(player);
            ParamCheck.IsNull(enemy);
            
            _player = player;
            _enemy = enemy;
            _fighters = new List<BaseCharacter> { player, enemy };
            _fled = false;
            _stillFighting = true;
        }

        public void Fight()
        {
            while (_stillFighting)
            {
                var turns = TurnManager.Build(_fighters);

                foreach (var turn in turns.ToList())
                {
                    StillFighting();
                    if (_stillFighting == false) break;

                    if (IsPlayerTurn(turn))
                    {
                        HandlePlayerTurn();
                    }
                    if(IsEnemyTurn(turn))
                    {
                        HandleEnemyTurn();
                    }
                }
            }

            var battleResult = new BattleResult(this);
            battleResult.Resolve();
        }

        private void HandlePlayerTurn()
        {
            var actionHandler = new ActionHandler(this, _player, _enemy);
            var playerInput = new PlayerInput();
            BasicAction action;
            bool handled;
            
            do
            {
                _player.PrintStatus();
                _enemy.PrintStatus();

                action = playerInput.GetInput();
                handled = actionHandler.ExecuteAction(action);

                Console.ReadKey();
                Console.Clear();
            }
            while (handled == false);
        }

        private void HandleEnemyTurn()
        {
            var actionHandler = new ActionHandler(this, _player, _enemy);
            
            _player.PrintStatus();
            _enemy.PrintStatus();

            actionHandler.ExecuteAction(BasicAction.BasicAttack);

            Console.ReadKey();
            Console.Clear();
        }

        private bool IsPlayerTurn(Turn turn)
        {
            return turn.GetCharacter().Equals(_player);
        }

        private bool IsEnemyTurn(Turn turn)
        {
            return turn.GetCharacter().Equals(_enemy);
        }

        private void StillFighting()
        {
            _stillFighting = _player.IsAlive() && _enemy.IsAlive() && !_fled;
        }

        public void SetFled(bool state)
        {
            _fled = state;
        }

        public bool GetFled()
        {
            return _fled;
        }

        public PlayerCharacter GetPlayer()
        {
            return _player;
        }

        public Enemy GetEnemy()
        {
            return _enemy;
        }
    }
}
