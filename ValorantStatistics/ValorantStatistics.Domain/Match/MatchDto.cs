using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain.Match
{
    public class MatchDto
    {
        public MatchInfoDto MatchInfo { get; set; }
        public List<PlayerDto> Players { get; set; }
        public List<CoachDto> Coaches { get; set; }
        public List<TeamDto> Teams { get; set; }
        public List<RoundResultDto> RoundResults { get; set; }
    }
}
