using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Cleric : CharacterClass
    {

        public Cleric(int playerLvl)
        {

            setFlavortxt("A priestly champion who wields divine magic in service of higher power");
            setSpellcastingAbility("Wisdom");
            setSpellList("Cleric");
            int[,] clericChart = new int[20, 10] {
                {3,2,0,0,0,0,0,0,0,0},
                {3,3,0,0,0,0,0,0,0,0},
                {3,4,2,0,0,0,0,0,0,0},
                {4,4,3,0,0,0,0,0,0,0},
                {4,4,3,2,0,0,0,0,0,0},
                {4,4,3,3,0,0,0,0,0,0},
                {4,4,3,3,1,0,0,0,0,0},
                {4,4,3,3,2,0,0,0,0,0},
                {4,4,3,3,3,1,0,0,0,0},
                {5,4,3,3,3,2,0,0,0,0},
                {5,4,3,3,3,2,1,0,0,0},
                {5,4,3,3,3,2,1,0,0,0},
                {5,4,3,3,3,2,1,1,0,0},
                {5,4,3,3,3,2,1,1,0,0},
                {5,4,3,3,3,2,1,1,1,0},
                {5,4,3,3,3,2,1,1,1,0},
                {5,4,3,3,3,2,1,1,1,1},
                {5,4,3,3,3,3,1,1,1,1},
                {5,4,3,3,3,3,2,1,1,1},
                {5,4,3,3,3,3,2,2,1,1},
            };
            setSpellChart(clericChart);
        }

        public override int getTotalSpellsKnown(int classLevel)
        {
            if(classLevel + this.getSpellcastingAbilityValue()<1)
            {
                return 1;
            }
            else { return classLevel + this.getSpellcastingAbilityValue(); }
        }

        public override string ToString()
        {
            return "Cleric";
        }
    }
}
