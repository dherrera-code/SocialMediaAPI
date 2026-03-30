using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaAPI.Entities
{
    public class DailyOverviewDTO
    {
        public string? SocialMedia { get; set; }
        public string? ViewsOrLikes { get; set; }
        public int Amounts { get; set; }
        public int TrendingPercentage { get; set; }
        
    }
}