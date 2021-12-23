using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class MatchInfoDto
    {
        public string MatchId { get; set; }
        public string MapId { get; set; }
        public int GameLengthMillis { get; set; }
        public long FameStartMillis { get; set; }
        public string ProvisioningFlowId { get; set; }
        public bool IsCompleted { get; set; }
        public string CustomGameName { get; set; }
        public string QueueId { get; set; }
        public string GameMode { get; set; }
        public bool IsRanked { get; set; }
        public string SeasonId { get; set; }
    }
}
