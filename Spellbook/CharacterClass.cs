using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    public abstract class CharacterClass
    {
        private int spellSaveDC;
        private int spellAttackMod;
        private int[] profBonus = new int[] {0, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6 };
        private string flavortxt;
        private string spellcastingAbility = "spellcasting";
        private int spellcastingAbilityValue = 0;
        private string spellList;
        private int totalspellsKnown;
        //2d array used for determining the level and number of spell slots characters have
        private int[,] spellslotchart = new int[20, 10] {
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
        };

        /// <summary>
        /// this method is used to get the flavor text for each class
        /// </summary>
        /// <returns></returns>
        public string getFlavortxt()
        {
            return flavortxt;
        }


        public void setFlavortxt(string newFlavorText)
        {
            flavortxt = newFlavorText;
        }

        public int getSpellcastingAbilityValue()
        {
            return spellcastingAbilityValue;
        }

        public void setSpellAbilityValue(int newvalue)
        {
            spellcastingAbilityValue = newvalue;
        }

        /// <summary>
        /// this is used when getting the name of each class
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();
        

        /// <summary>
        /// returns the number of spell that can be learned by a character at that level
        /// for the sake of formatting I have set the current max to be 50
        /// </summary>
        /// <returns></returns>
        public abstract int getTotalSpellsKnown(int classLevel);
     

        public int getProfBonus(int level)
        {
            return profBonus[level];
        }

        /// <summary>
        /// used to aquire the spellcasting ab for things like damage calculation 
        /// </summary>
        /// <returns></returns>
        public string getSpellcastingAbility()
        {
            return spellcastingAbility;
        }

        public void setSpellcastingAbility(string newAbility)
        {
            spellcastingAbility = newAbility;
        }

        public string getSpellList() {
            return spellList;
        }

        public void setSpellList(string newspellList)
        {
            spellList = newspellList;
        }

        /// <summary>
        /// Setter for the spellslot chart
        /// </summary>
        /// <param name="newspellslotchart"></param>
        public void setSpellChart(int[,] newspellslotchart)
        {
            spellslotchart = newspellslotchart;
        }


        public void setTotalSpells(int spellnum)
        {
            totalspellsKnown = spellnum;
        }

        

        /// <summary>
        /// finds the spell slots available per level
        /// </summary>
        /// <param name="playerLevel"></param>
        /// <param name="spellLevel"></param>
        /// <returns></returns>
        public int getspellslots(int playerLevel, int spellLevel)
        {
            return spellslotchart[playerLevel,spellLevel];
        }

        /// <summary>
        /// this function will come in handy when trying to recieve the 
        /// </summary>
        /// <param name="playerLevel"></param>
        /// <returns></returns>
        public int getHighestLevelSpell(int playerLevel)
        {
            int spellLevel = 0;
            while (getspellslots(playerLevel, spellLevel) != 0)
            {
                spellLevel++;
            }

            return spellLevel;
        }

    }
}
