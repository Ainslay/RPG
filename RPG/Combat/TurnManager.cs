using RPG.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static void Remove()
        {
            _turns.RemoveAt(0);
        }

        // Musze zmienić jeśli wartość jest taka sama!! IComparer
        private static List<BaseCharacter> GetSortedFighters(List<BaseCharacter> fighters)
        {
            return fighters.OrderByDescending(fighter => fighter.GetCurrentIniciative()).ToList();
        }
    }
}
