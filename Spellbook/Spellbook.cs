using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Spellbook
{
    class Spellbook
    {
        private static HashSet<Spell> spellList = new HashSet<Spell>();
        
        public Spellbook()
        {
            XmlDocument phb = new XmlDocument();
            XmlDocument scag = new XmlDocument();
            XmlDocument ee = new XmlDocument();
            XmlDocument xgte = new XmlDocument();
            phb.Load("../../PHBSpells.xml");
            scag.Load("../../SCAGSpells 1.2.xml");
            ee.Load("../../EE Spells 2.6.xml");
            xgte.Load("../../XGTESpells.xml");
            GenerateSpellBook(phb);
            GenerateSpellBook(scag);
            GenerateSpellBook(ee);
            GenerateSpellBook(xgte);
        }

       


        private void GenerateSpellBook(XmlDocument xmlDoc)
        {
            XmlNodeList spellNodeList = xmlDoc.GetElementsByTagName("spell");
            for (int i = 0; i < spellNodeList.Count; i++)
            {
                Spell importedSpell = new Spell();
                XmlNodeList individualSpelNodeList = spellNodeList[i].ChildNodes;
                for(int j = 0; j< individualSpelNodeList.Count; j++)
                {
                    if (individualSpelNodeList[j].Name == "name")
                    {
                        importedSpell.name = individualSpelNodeList[j].InnerText;
                    }
                    else if (individualSpelNodeList[j].Name == "level")
                    {
                        importedSpell.level = Int32.Parse(individualSpelNodeList[j].InnerText);
                    }
                    else if(individualSpelNodeList[j].Name == "school")
                    {
                        importedSpell.school = individualSpelNodeList[j].InnerText;
                    }
                    else if(individualSpelNodeList[j].Name == "time")
                    {
                        importedSpell.time = individualSpelNodeList[j].InnerText;
                    }
                    else if (individualSpelNodeList[j].Name == "range")
                    {
                        importedSpell.range = individualSpelNodeList[j].InnerText;
                    }
                    else if (individualSpelNodeList[j].Name == "text")
                    {
                        importedSpell.setText(individualSpelNodeList[j].InnerText);
                    }
                    else if (individualSpelNodeList[j].Name == "components")
                    {
                        importedSpell.components = individualSpelNodeList[j].InnerText;
                    }
                    else if (individualSpelNodeList[j].Name == "duration")
                    {
                        importedSpell.duration = individualSpelNodeList[j].InnerText;
                    }
                    else if (individualSpelNodeList[j].Name == "classes")
                    {
                        importedSpell.classes = individualSpelNodeList[j].InnerText.Replace(" ","").Split(',');
                    }
                    else if (individualSpelNodeList[j].Name == "roll")
                    {
                        importedSpell.setRoll(individualSpelNodeList[j].InnerText);
                    }


                }
                spellList.Add(importedSpell);
            }
        }

        public List<Spell> GetSpells()
        {
            return spellList.ToList();
        }
    }
}
