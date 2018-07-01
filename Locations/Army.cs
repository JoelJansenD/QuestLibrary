using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Locations
{
    public class Army : Faction
    {
        public string Alignment;
        public string Type;

        public Army(string type)
        {
            Type = type;
        }
    }
}
