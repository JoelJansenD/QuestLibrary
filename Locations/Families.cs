using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Locations
{
    public class Families : List<Family>
    {
        public Family this[string name]
        {
            get
            {
                return this.FirstOrDefault(family => family.Name == name);
            }
        }
    }
}
