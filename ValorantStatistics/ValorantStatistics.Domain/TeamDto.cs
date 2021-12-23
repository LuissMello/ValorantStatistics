using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class TeamDto
    {
        /// <summary>
        /// This is an arbitrary string. Red and Blue in bomb modes.The puuid of the player in deathmatch.
        /// </summary>
        public string TeamId { get; set; } 
            
        public bool Won { get; set; }
        public int RoundsPlayed { get; set; }
        public int RoundsWon { get; set; }
        /// <summary>
        /// Team points scored.Number of kills in deathmatch.
        /// </summary>
        public int NumPoints { get; set; }
    }
}
