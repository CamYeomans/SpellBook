using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Rogue : CharacterClass
    {
        private int[] spellsknown = new int[] { 0, 0, 0, 3, 4, 4, 4, 5, 6, 6, 7, 8, 8, 9, 10, 10, 11, 11, 11, 12, 13 };

        public Rogue(int lvl)
        {
            setFlavortxt("A scoundrel who uses stealth and trickery to overcome obstacles and enemies");
            setSpellcastingAbility("Intelligence");
            setSpellList("wizard");
            int[,] rogueChart = new int[20, 10] {
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {3,2,0,0,0,0,0,0,0,0},
                {3,3,0,0,0,0,0,0,0,0},
                {3,3,0,0,0,0,0,0,0,0},
                {3,3,0,0,0,0,0,0,0,0},
                {3,4,2,0,0,0,0,0,0,0},
                {3,4,2,0,0,0,0,0,0,0},
                {3,4,2,0,0,0,0,0,0,0},
                {4,4,3,0,0,0,0,0,0,0},
                {4,4,3,0,0,0,0,0,0,0},
                {4,4,3,0,0,0,0,0,0,0},
                {4,4,3,2,0,0,0,0,0,0},
                {4,4,3,2,0,0,0,0,0,0},
                {4,4,3,2,0,0,0,0,0,0},
                {4,4,3,3,0,0,0,0,0,0},
                {4,4,3,3,0,0,0,0,0,0},
                {4,4,3,3,0,0,0,0,0,0},
                {4,4,3,3,1,0,0,0,0,0},
                {4,4,3,3,1,0,0,0,0,0},
            };
            setSpellChart(rogueChart);
            setTotalSpells(getTotalSpellsKnown(lvl));
        }

        public override int getTotalSpellsKnown(int classLevel)
        {
            return spellsknown[classLevel];
        }

        public override string ToString()
        {
            return "Rogue";
        }
    }
}
