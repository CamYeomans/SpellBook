using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Monk : CharacterClass
    {
        public Monk(int level)
        {

        }
        public override int getTotalSpellsKnown(int classLevel)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Monk";
        }
    }
}
