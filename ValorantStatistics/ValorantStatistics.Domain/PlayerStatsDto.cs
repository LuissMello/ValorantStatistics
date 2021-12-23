using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class PlayerStatsDto
    {
        public int Score { get; set; }
        public int ToundsPlayed { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int PlaytimeMillis { get; set; }
        public AbilityCastsDto AbilityCasts { get; set; }
    }
}
