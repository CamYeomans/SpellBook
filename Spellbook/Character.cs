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

        public int getLevel()
        {
            return lvl;
        }

        public CharacterClass getClass()
        {
            return selectedClass;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public string getName()
        {
            return name;
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
            if (charClass == "The Barbarian")
            {
                selectedClass = new Barbarian();
            }
            else if (charClass == "The Bard")
            {
                selectedClass = new Bard(lvl);
            }
            else if (charClass == "The Cleric")
            {
                selectedClass = new Cleric(lvl);
            }
            else if (charClass == "The Druid")
            {

            }
            else if (charClass == "The Fighter")
            {

            }
            else if (charClass == "The Monk")
            {

            }
            else if (charClass == "The Paladin")
            {

            }
            else if (charClass == "The Ranger")
            {

            }
            else if (charClass == "The Rogue")
            {

            }
            else if (charClass == "The Sorcerer")
            {

            }
            else if (charClass == "The Warlock")
            {

            }
            else { }
        }


    }
}
