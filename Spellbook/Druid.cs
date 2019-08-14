using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Druid : CharacterClass
    {

        public Druid(int playerLevel)
        {
            setFlavortxt("A priest of the old faith, wielding the powers of nature and adopting animal forms");
            setSpellcastingAbility("Wisdom");
            setSpellList("druid");
            int[,] druidChart = new int[20, 10] {
                {2,2,0,0,0,0,0,0,0,0},
                {2,3,0,0,0,0,0,0,0,0},
                {2,4,2,0,0,0,0,0,0,0},
                {3,4,3,0,0,0,0,0,0,0},
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
            setSpellChart(druidChart);

        }

        public override int getTotalSpellsKnown(int classLevel)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Druid";
        }
    }
}
