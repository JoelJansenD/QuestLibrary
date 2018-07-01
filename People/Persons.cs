using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.People
{
    class Persons : List<Person>
    {
        public Person this[string ID]
        {
            get
            {
                return this.FirstOrDefault(person => person.ID == ID);
            }
        }
    }
}
