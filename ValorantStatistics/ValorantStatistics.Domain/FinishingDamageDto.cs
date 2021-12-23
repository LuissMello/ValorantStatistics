using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStatistics.Domain
{
    public class FinishingDamageDto
    {
        public string DamageType { get; set; }
        public string DamageItem { get; set; }
        public bool IsSecondaryFireMode { get; set; }
    }
}
