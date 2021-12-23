using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class EconomyDto
    {
        public int LoadoutValue { get; set; }
        public string Weapon { get; set; }
        public string Armor { get; set; }
        public int Remaining { get; set; }
        public int Spent { get; set; }
    }
}
