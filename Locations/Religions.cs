using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Locations
{
    public class Religions : List<Religion>
    {
        public Religion this[string god]
        {
            get
            {
                return this.FirstOrDefault(religion => religion.God == god);
            }
        }
    }
}
