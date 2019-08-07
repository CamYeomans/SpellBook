using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Character
    {
        private string name;
        private int lvl;
        private CharacterClass selectedClass;
        private Spell[] spellbook;

        public Character()
        {

        }

        public Character(string newname, int level, CharacterClass charclass)
        {
            name = newname;
            lvl = level;
            selectedClass = charclass;
        }

        public void setLevel(int level)
        {
            lvl = level;
        }

        public CharacterClass GetCharClass()
        {
            return selectedClass;
        }


        /// <summary>
        /// always set level before setting class
        /// </summary>
        /// <param name="charClass"></param>
        public void setClass(string charClass)
        {
            if (charClass == "barbarian")
            {

            }
            else if (charClass == "bard")
            {
                selectedClass = new Bard(lvl);
            }
            else if (charClass == "cleric")
            {

            }
            else if (charClass == "druid")
            {

            }
            else if (charClass == "fighter")
            {

            }
            else if (charClass == "monk")
            {

            }
            else if (charClass == "paladin")
            {

            }
            else if (charClass == "ranger")
            {

            }
            else if (charClass == "rogue")
            {

            }
            else if (charClass == "sorcerer")
            {

            }
            else if (charClass == "warlock")
            {

            }
            else { }
        }


    }
}
