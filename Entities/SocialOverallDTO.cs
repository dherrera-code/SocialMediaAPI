using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaAPI.Entities
{
    public class SocialOverallDTO
    {
        public string? SocialMedia { get; set; }
        public string? Username { get; set; }
        public int FollowerCount { get; set; }
        public int AddedFollowers { get; set; }
    }
}