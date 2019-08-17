using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Ranger : CharacterClass
    {
        private int[] spellsknown = new int[] { 0, 0, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11 };

        public Ranger(int level)
        {
            setFlavortxt("A warrior who combats theats on the edges of civilization");
            setSpellcastingAbility("Wisdom");
            setSpellList("Ranger");
            int[,] rangerChart = new int[20, 10] {
                {0,0,0,0,0,0,0,0,0,0},
                {0,2,0,0,0,0,0,0,0,0},
                {0,3,0,0,0,0,0,0,0,0},
                {0,3,0,0,0,0,0,0,0,0},
                {0,4,2,0,0,0,0,0,0,0},
                {0,4,2,0,0,0,0,0,0,0},
                {0,4,3,0,0,0,0,0,0,0},
                {0,4,3,0,0,0,0,0,0,0},
                {0,4,3,2,0,0,0,0,0,0},
                {0,4,3,2,0,0,0,0,0,0},
                {0,4,3,3,0,0,0,0,0,0},
                {0,4,3,3,0,0,0,0,0,0},
                {0,4,3,3,1,0,0,0,0,0},
                {0,4,3,3,1,0,0,0,0,0},
                {0,4,3,3,2,0,0,0,0,0},
                {0,4,3,3,2,0,0,0,0,0},
                {0,4,3,3,3,1,0,0,0,0},
                {0,4,3,3,3,1,0,0,0,0},
                {0,4,3,3,3,2,0,0,0,0},
                {0,4,3,3,3,2,0,0,0,0},
            };
            setSpellChart(rangerChart);
            setTotalSpells(getTotalSpellsKnown(level));
        }
        public override int getTotalSpellsKnown(int classLevel)
        {
            return spellsknown[classLevel];
        }

        public override string ToString()
        {
            return "Ranger";
        }
    }
}
