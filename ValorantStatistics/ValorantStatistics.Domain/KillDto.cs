using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class KillDto
    {
        public int TimeSinceGameStartMillis { get; set; }
        public int TimeSinceRoundStartMillis { get; set; }
        /// <summary>
        /// PUUID
        /// </summary>
        public string Killer { get; set; }
        /// <summary>
        /// PUUID
        /// </summary>

        public string Victim { get; set; }
        public LocationDto VictimLocation { get; set; }
        /// <summary>
        /// List of PUUIDs
        /// </summary>
        public List<string> Assistants { get; set; }
        public List<PlayerLocationsDto> PlayerLocations { get; set; }
        public FinishingDamageDto FinishingDamage { get; set; }
    }
}
