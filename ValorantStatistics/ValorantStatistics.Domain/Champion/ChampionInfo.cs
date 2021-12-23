using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain.Champion
{
    public class ChampionInfo
    {
        public int MaxNewPlayerLevel { get; set; }
        public List<int> FreeChampionIdsForNewPlayers { get; set; }
        public List<int> FreeChampionIds { get; set; }
    }
}
