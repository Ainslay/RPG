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
        private BattleInterface battleInterface; 
        private bool _fled;

        public Battle(PlayerCharacter player, Enemy enemy)
        {
            ParamCheck.IsNull(player);
            ParamCheck.IsNull(enemy);
            
            _player = player;
            _enemy = enemy;
            battleInterface = new BattleInterface(player, enemy);
            _fighters = new List<BaseCharacter> { player, enemy };
            _fled = false;
        }

        public void Fight()
        {
            bool stillFighting = true;

            while (stillFighting)
            {
                var turns = TurnManager.Build(_fighters);

                foreach (var turn in turns.ToList())
                {
                    stillFighting = StillFighting();
                    if (stillFighting == false) break;

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
            var actionHandler = new PlayerActionHandler(new BattleInfo(this));
            var playerInput = new PlayerInput(battleInterface);
            BasicAction action;

            battleInterface.Print();

            action = playerInput.GetInput();
            actionHandler.ExecuteAction(action);

            Console.ReadKey();
            Console.Clear();
        }

        private void HandleEnemyTurn()
        {
            var actionHandler = new EnemyActionHandler(new BattleInfo(this));

            battleInterface.Print();

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

        private bool StillFighting()
        {
            return _player.IsAlive() && _enemy.IsAlive() && !_fled;
        }

        public void SetFled()
        {
            _fled = true;
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
