using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Warlock : CharacterClass
    {
        private int[] spellsknown = new int[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15 };

        public Warlock(int level)
        {
            setFlavortxt("A wielder of magic that is derived from a bargain with an extraplanar entity");
            setSpellcastingAbility("Charisma");
            setSpellList("Warlock");
            int[,] warlockChart = new int[20, 10] {
                {2,1,0,0,0,0,0,0,0,0},
                {2,2,0,0,0,0,0,0,0,0},
                {2,0,2,0,0,0,0,0,0,0},
                {3,0,2,0,0,0,0,0,0,0},
                {3,0,0,2,0,0,0,0,0,0},
                {3,0,0,2,0,0,0,0,0,0},
                {3,0,0,0,2,0,0,0,0,0},
                {3,0,0,0,0,2,0,0,0,0},
                {3,0,0,0,0,0,2,0,0,0},
                {4,0,0,0,0,0,2,0,0,0},
                {4,0,0,0,0,0,3,0,0,0},
                {4,0,0,0,0,0,3,0,0,0},
                {4,0,0,0,0,0,3,0,0,0},
                {4,0,0,0,0,0,3,0,0,0},
                {4,0,0,0,0,0,3,0,0,0},
                {4,0,0,0,0,0,3,0,0,0},
                {4,0,0,0,0,0,4,0,0,0},
                {4,0,0,0,0,0,4,0,0,0},
                {4,0,0,0,0,0,4,0,0,0},
                {4,0,0,0,0,0,4,0,0,0},
            };
            setSpellChart(warlockChart);
            setTotalSpells(getTotalSpellsKnown(level));
        }
        public override int getTotalSpellsKnown(int classLevel)
        {
            return spellsknown[classLevel];
        }

        public override string ToString()
        {
            return "Warlock";
        }
    }
}
