using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Locations
{
    public class Religion : Faction
    {
        public string God;

        public Religion(string god)
        {
            God = god;
        }
    }
}
