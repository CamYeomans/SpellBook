using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    class Spell
    {
        public string name { get; set; }
        public int level { get; set; }
        public string school { get; set; }
        public string time { get; set; }
        public string range { get; set; }
        public string components { get; set; } 
        public string duration { get; set; }
        public string[] classes { get; set; }
        public string text { get; set; }
        public string roll { get; set; }


        public Spell(string newname, int newlevel, string newschool, string newtime, string newrange, string newcomponents, string newduration, string[] newclasses, string newtext)
        {
            name = newname;
            level = newlevel;
            school = newschool;
            time = newtime;
            range = newrange;
            components = newcomponents;
            duration = newduration;
            classes = newclasses;
            text = newtext;
        }
    }
}
