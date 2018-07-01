using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Locations
{
    public class Armies : List<Army>
    {
        public Army this[string type]
        {
            get
            {
                return this.FirstOrDefault(army => army.Type == type);
            }
        }
    }
}
