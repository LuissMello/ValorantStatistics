using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class DamageDto
    {
        /// <summary>
        /// PUUID
        /// </summary>
        public string Receiver { get; set; }
        public int Damage { get; set; }
        public int Legshots { get; set; }
        public int Bodyshots { get; set; }
        public int Headshots { get; set; }
    }
}
