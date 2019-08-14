using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Sorcerer : CharacterClass
    {
        private int[] spellsknown = new int[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 13, 13, 14, 14, 15, 15, 15, 15 };

        public Sorcerer(int level)
        {
            setFlavortxt("A spellcaster who draws on inherent magic from a gift or bloodline");
            setSpellcastingAbility("Charisma");
            setSpellList("sorcerer");
            int[,] sorcererChart = new int[20, 10] {
                {4,2,0,0,0,0,0,0,0,0},
                {4,3,0,0,0,0,0,0,0,0},
                {4,4,2,0,0,0,0,0,0,0},
                {5,4,3,0,0,0,0,0,0,0},
                {5,4,3,2,0,0,0,0,0,0},
                {5,4,3,3,0,0,0,0,0,0},
                {5,4,3,3,1,0,0,0,0,0},
                {5,4,3,3,2,0,0,0,0,0},
                {5,4,3,3,3,1,0,0,0,0},
                {6,4,3,3,3,2,0,0,0,0},
                {6,4,3,3,3,2,1,0,0,0},
                {6,4,3,3,3,2,1,0,0,0},
                {6,4,3,3,3,2,1,1,0,0},
                {6,4,3,3,3,2,1,1,0,0},
                {6,4,3,3,3,2,1,1,1,0},
                {6,4,3,3,3,2,1,1,1,0},
                {6,4,3,3,3,2,1,1,1,1},
                {6,4,3,3,3,2,1,1,1,1},
                {6,4,3,3,3,2,2,1,1,1},
                {6,4,3,3,3,2,2,2,1,1},
            };
            setSpellChart(sorcererChart);
            setTotalSpells(getTotalSpellsKnown(level));
        }

        public override int getTotalSpellsKnown(int classLevel)
        {
            return spellsknown[classLevel];
        }

        public override string ToString()
        {
            return "Sorcerer";
        }
    }
}
