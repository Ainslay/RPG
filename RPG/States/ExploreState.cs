using System;

using RPG.Character.Enemies;
using RPG.Character.Enemies.Tools;
using RPG.Character.Player;
using RPG.Controls;
using RPG.Utilities;

namespace RPG.States
{
    class ExploreState : IState
    {
        private IStateController _stateController;
        private PlayerCharacter _player;

        public ExploreState(IStateController stateController, PlayerCharacter player)
        {
            ParamCheck.IsNull(stateController);
            ParamCheck.IsNull(player);

            _stateController = stateController;
            _player = player;
        }

        public void Handle()
        {
            Console.Clear();
            Console.WriteLine("You are now in exploration state!");
            Console.WriteLine();

            // TODO: StoryTeller which handles all of this stuff

            var enemy = RandomEnemyFactory.Create(_player.GetLevelValue(), new StatMultiplier());

            Console.WriteLine($"{enemy.GetName()} appears out of nowhere! " +
                $"\nYour swift judgement tells yout that threat level of this monster is: {enemy.GetThreatLevel()}");
            Console.WriteLine();
            Console.WriteLine("Do you wish to fight it?");
            Console.WriteLine($"{(char)KeyBindings.Key1}. Yes");
            Console.WriteLine($"{(char)KeyBindings.Key2}. Hell nah");
            Console.WriteLine($"{(char)KeyBindings.Key3}. Inventory");
            Console.WriteLine();

            var input = (KeyBindings)Console.ReadKey(true).Key;

            switch (input)
            {
                case KeyBindings.Key1:
                    _stateController.SetState(new BattleState(_stateController, _player, enemy));
                    break;
                case KeyBindings.Key2:
                    Console.WriteLine("Coward! You ran to your rabbit hole.");
                    Console.ReadKey();
                    break;
                case KeyBindings.Key3:
                    _player.PrintEquipment();
                    break;
                default:
                    break;
            }
        }
    }
}
