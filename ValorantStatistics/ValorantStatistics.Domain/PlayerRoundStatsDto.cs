using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class PlayerRoundStatsDto
    {
        public string Puuid { get; set; }
        public List<KillDto> Kills { get; set; }
        public List<DamageDto> Damage { get; set; }
        public int Score { get; set; }
        public EconomyDto Economy { get; set; }
        public AbilityDto Ability { get; set; }
    }
}
