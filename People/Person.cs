using QuestLibrary.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.People
{
    class Person
    {
        public Area Home;

        public string ID;
        public string Name;
        public string Race;
        public string Gender;
        public string Alignment => Alignment ?? "Lawful good";
    }
}
