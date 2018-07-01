using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Locations
{
    public class Guild : Faction
    {
        public string Type;

        public Guild(string type)
        {
            Type = type;
        }
    }
}
