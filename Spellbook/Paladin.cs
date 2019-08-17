using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Paladin : CharacterClass
    {
        public Paladin(int level)
        {
            setFlavortxt("A holy warrior bound to a sacred oath");
            setSpellcastingAbility("Charisma");
            setSpellList("Paladin");
            int[,] palyChart = new int[20, 10] {
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
            setSpellChart(palyChart);
        }
        public override int getTotalSpellsKnown(int classLevel)
        {
            if (classLevel + (this.getSpellcastingAbilityValue()/2) < 1)
            {
                return 1;
            }
            else { return classLevel + (this.getSpellcastingAbilityValue()/2); }
        }

        public override string ToString()
        {
            return "Paladin";
        }
    }
}
