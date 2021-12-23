using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class PlayerLocationsDto
    {
        public string Puuid { get; set; }
        public float ViewRadians { get; set; }
        public LocationDto Location { get; set; }
    }
}
