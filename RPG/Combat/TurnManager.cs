using RPG.Character;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace RPG.Combat
{
    static class TurnManager
    {
        private static List<Turn> _turns;

        public static List<Turn> Build(List<BaseCharacter> fighters)
        {
            var sortedFighters = GetSortedFighters(fighters);

            // Mapowanie obiektów jednego typu na inny !
            _turns = sortedFighters.Select(fighter => new Turn(fighter)).ToList();

            return _turns;
        }

        private static List<BaseCharacter> GetSortedFighters(List<BaseCharacter> fighters)
        {
            fighters.Sort(new SortFightersByIniciativeDescending());
            return fighters;
            //return fighters.OrderByDescending(fighter => fighter.GetCurrentIniciative()).ToList();
        }

        private class SortFightersByIniciativeDescending : IComparer<BaseCharacter>
        {
            public int Compare(BaseCharacter fighter1, BaseCharacter fighter2)
            {
                if(fighter1.GetCurrentIniciative() < fighter2.GetCurrentIniciative())
                {
                    return 1;
                }
                else if(fighter1.GetCurrentIniciative() > fighter2.GetCurrentIniciative())
                {
                    return -1;
                }
                else
                {
                    var random = new Random().Next(0,100);

                    if(random >= 50)
                    {
                        return 1;
                    }

                    return 0;
                }
            }
        }
    }
}
