using System;
using System.Collections.Generic;
using System.Linq;

using RPG.Character;
using RPG.Utilities;

namespace RPG.Combat.Turns
{
    static class TurnManager
    {
        private static List<Turn> _turns;

        public static List<Turn> Build(List<BaseCharacter> fighters)
        {
            ParamCheck.IsNullOrEmpty(fighters);

            var sortedFighters = GetSortedFighters(fighters);

            _turns = sortedFighters.Select(fighter => new Turn(fighter)).ToList();

            return _turns;
        }

        private static List<BaseCharacter> GetSortedFighters(List<BaseCharacter> fighters)
        {
            fighters.Sort(new SortFightersByIniciativeDescending());
            return fighters;
        }

        private class SortFightersByIniciativeDescending : IComparer<BaseCharacter>
        {
            public int Compare(BaseCharacter fighter1, BaseCharacter fighter2)
            {
                if (LowerThan(fighter1, fighter2))
                {
                    return 1;
                }
                else if (GreaterThan(fighter1, fighter2))
                {
                    return -1;
                }
                else
                {
                    return new Random().Next(0, 1);
                }
            }

            private bool GreaterThan(BaseCharacter fighter1, BaseCharacter fighter2)
            {
                return fighter1.GetCurrentIniciative() > fighter2.GetCurrentIniciative();
            }

            private bool LowerThan(BaseCharacter fighter1, BaseCharacter fighter2)
            {
                return fighter1.GetCurrentIniciative() < fighter2.GetCurrentIniciative();
            }
        }
    }
}
