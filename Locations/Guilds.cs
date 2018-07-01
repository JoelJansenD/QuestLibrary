using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Locations
{
    public class Guilds : List<Guild>
    {
        public Guild this[string type]
        {
            get
            {
                return this.FirstOrDefault(guild => guild.Type == type);
            }
        }

        public void AddGuild(Guild newGuild)
        {
            int index = FindIndex(guild => (guild.Type == newGuild.Type));

            if (index == -1)
            {
                Add(newGuild);
            }
            else
            {
                this[index] = newGuild;
            }
        }
    }
}
