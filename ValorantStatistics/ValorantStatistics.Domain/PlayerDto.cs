using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class PlayerDto
    {
        public string Puuid { get; set; }
        public string GameName { get; set; }
        public string TagLine { get; set; }
        public string TeamId { get; set; }
        public string PartyId { get; set; }
        public string CharacterId { get; set; }
        public PlayerStatsDto Stats { get; set; }
        public int CompetitiveTier { get; set; }
        public string PlayerCard { get; set; }
        public string PlayerTitle { get; set; }
    }
}
