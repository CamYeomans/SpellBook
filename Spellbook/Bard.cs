using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Bard : CharacterClass
    {
       private int[] spellsknown = new int[] {0,4,5,6,7,8,9,10,11,12,14,15,15,16,18,19,19,20,22,22,22};
        
        public Bard(int level)
        {
            setFlavortxt("An inspiring magician whose power echoes the music of creation");
            setSpellcastingAbility("Charisma");
            setSpellList("Bard");
            int[,] bardChart = new int[20, 10] { 
                {2,2,0,0,0,0,0,0,0,0},
                {2,3,0,0,0,0,0,0,0,0},
                {2,4,2,0,0,0,0,0,0,0},
                {2,4,3,0,0,0,0,0,0,0},
                {3,4,3,2,0,0,0,0,0,0},
                {3,4,3,3,0,0,0,0,0,0},
                {3,4,3,3,1,0,0,0,0,0},
                {3,4,3,3,2,0,0,0,0,0},
                {3,4,3,3,3,1,0,0,0,0},
                {4,4,3,3,3,2,0,0,0,0},
                {4,4,3,3,3,2,1,0,0,0},
                {4,4,3,3,3,2,1,0,0,0},
                {4,4,3,3,3,2,1,1,0,0},
                {4,4,3,3,3,2,1,1,0,0},
                {4,4,3,3,3,2,1,1,1,0},
                {4,4,3,3,3,2,1,1,1,0},
                {4,4,3,3,3,2,1,1,1,1},
                {4,4,3,3,3,3,1,1,1,1},
                {4,4,3,3,3,3,2,1,1,1},
                {4,4,3,3,3,3,2,2,1,1},
            };
            setSpellChart(bardChart);
            setTotalSpells(getTotalSpellsKnown(level));

        }

        public override int getTotalSpellsKnown(int classLevel)
        {
            return spellsknown[classLevel];
        }

        public override string ToString()
        {
            return "Bard";
        }
    }
}
