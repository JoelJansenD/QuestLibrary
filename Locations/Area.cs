using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Locations
{
    public class Area
    {
        public Armies Armies;
        public Families Families;
        public Guilds Guilds;
        public Religions Religions;

        public string[] FirstNames;
        public string[] LastNames;

        public string CopperName => CopperName ?? "Copper";
        public string ElectrumName => ElectrumName ?? "Electrum";
        public string GoldName => GoldName ?? "Gold";
        public string PlatinumName => PlatinumName ?? "Platinum";
        public string SilverName => SilverName ?? "Silver";

        public string Name;

        public Area()
        {
            Guilds = new Guilds();
        }
    }
}
