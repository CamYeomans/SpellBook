using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Barbarian : CharacterClass
    {
        public override int getTotalSpellsKnown(int classLevel)
        {
            return 0;
        }

        public override string ToString()
        {
            return "Barbarian";
        }
    }
}
