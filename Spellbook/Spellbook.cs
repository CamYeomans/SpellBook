using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Spellbook
    {
        private static HashSet<Spell> spellList = new HashSet<Spell>();
        
        public Spellbook()
        {

        }

        public static void OrderByName()
        {
            HashSet<Spell> tempSpellList = new HashSet<Spell>();
            IEnumerable<Spell> query = spellList.OrderBy(spell => spell.name);
            foreach (Spell spell in query)
            {
                tempSpellList.Add(spell);
            }
            spellList = tempSpellList;
        }

        public static void OrderByLevel()
        {
            HashSet<Spell> tempSpellList = new HashSet<Spell>();
            IEnumerable<Spell> query = spellList.OrderBy(spell => spell.level);
            foreach (Spell spell in query)
            {
                tempSpellList.Add(spell);
            }
            spellList = tempSpellList;
        }

    }
}
