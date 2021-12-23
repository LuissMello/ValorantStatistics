using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class RoundResultDto
    {
        public int RoundNum { get; set; }
        public string RoundResult { get; set; }
        public string RoundCeremony { get; set; }
        public string WinningTeam { get; set; }
        /// <summary>
        /// PUUID of player
        /// </summary>
        public string BombPlanter { get; set; }
        /// <summary>
        /// PUUID of player
        /// </summary>
        public string BombDefuser { get; set; }
        public int PlantRoundTime { get; set; }
        public List<PlayerLocationsDto>  plantPlayerLocations { get; set; }
        public LocationDto PlantLocation { get; set; }
        public string PlantSite { get; set; }
        public int DefuseRoundTime { get; set; }
        public List<PlayerLocationsDto> DefusePlayerLocations { get; set; }
        public LocationDto DefuseLocation { get; set; }
        public List<PlayerRoundStatsDto> PlayerStats { get; set; }
        public string RoundResultCode { get; set; }
    }
}
