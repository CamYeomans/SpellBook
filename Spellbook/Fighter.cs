using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Fighter : CharacterClass
    {
        private int[] spellsknown = new int[] {0, 0, 0, 3, 4, 4, 4, 5, 6, 6, 7, 8, 8, 9, 10, 10, 11, 11, 11, 12, 13};
        public Fighter(int level)
        {
            setFlavortxt("A master of martial combat, skilled with a variety of weapons and armor");
            setSpellcastingAbility("Intelligence");
            setSpellList("Wizard");
            int[,] FighterChart = new int[20, 10] {
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {2,2,0,0,0,0,0,0,0,0},
                {2,3,0,0,0,0,0,0,0,0},
                {2,3,0,0,0,0,0,0,0,0},
                {2,3,0,0,0,0,0,0,0,0},
                {2,4,2,0,0,0,0,0,0,0},
                {2,4,2,0,0,0,0,0,0,0},
                {2,4,2,0,0,0,0,0,0,0},
                {3,4,3,0,0,0,0,0,0,0},
                {3,4,3,0,0,0,0,0,0,0},
                {3,4,3,0,0,0,0,0,0,0},
                {3,4,3,2,0,0,0,0,0,0},
                {3,4,3,2,0,0,0,0,0,0},
                {3,4,3,2,0,0,0,0,0,0},
                {3,4,3,3,0,0,0,0,0,0},
                {3,4,3,3,0,0,0,0,0,0},
                {3,4,3,3,0,0,0,0,0,0},
                {3,4,3,3,1,0,0,0,0,0},
                {3,4,3,3,1,0,0,0,0,0},
            };
            setSpellChart(FighterChart);
            setTotalSpells(getTotalSpellsKnown(level));
        }

        public override int getTotalSpellsKnown(int classLevel)
        {
            return spellsknown[classLevel];
        }

        public override string ToString()
        {
            return "Fighter";
        }
    }
}
