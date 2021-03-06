﻿using System;
using System.Collections.Generic;
using System.Linq;

using RPG.Actions;
using RPG.Character;
using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Utilities;
using RPG.Input;
using RPG.Input.Result;
using RPG.Combat.Turns;

namespace RPG.Combat.Battles
{
    class Battle
    {
        private PlayerCharacter _player;
        private Enemy _enemy;
        private List<BaseCharacter> _fighters;
        private BattleInterface _battleInterface;
        private bool _fled;

        public Battle(PlayerCharacter player, Enemy enemy)
        {
            ParamCheck.IsNull(player);
            ParamCheck.IsNull(enemy);

            _player = player;
            _enemy = enemy;
            _battleInterface = new BattleInterface(player, enemy);
            _fighters = new List<BaseCharacter> { player, enemy };
            _fled = false;
        }

        public void Fight()
        {
            while (StillFighting())
            {
                var turns = TurnManager.Build(_fighters);

                foreach (var turn in turns.ToList())
                {
                    if (StillFighting() == false) break;

                    if (IsPlayerTurn(turn))
                    {
                        HandlePlayerTurn();
                    }
                    if (IsEnemyTurn(turn))
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
            _player.RecalculateCurrentStats();

            var actionHandler = new PlayerActionHandler(new BattleInfo(this));
            _battleInterface.PrintStatuses();

            var inputResult = TryGetInputResult(new BattleInput());

            actionHandler.ExecuteAction(inputResult.GetValidInput());

            Console.ReadKey();
            Console.Clear();
        }

        private InputResult<BasicAction> TryGetInputResult(BattleInput playerInput)
        {
            InputResult<BasicAction> inputResult;
            do
            {
                inputResult = playerInput.GetInput();
            }
            while (!inputResult.IsValid());

            return inputResult;
        }

        private void HandleEnemyTurn()
        {
            _enemy.RecalculateCurrentStats();

            var actionHandler = new EnemyActionHandler(new BattleInfo(this));

            _battleInterface.PrintStatuses();

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

        public virtual PlayerCharacter GetPlayer()
        {
            return _player;
        }

        public virtual Enemy GetEnemy()
        {
            return _enemy;
        }
    }
}
