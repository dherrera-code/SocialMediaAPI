using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Entities;
using SocialMediaAPI.Service;

namespace SocialMediaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocialController(Social social) : ControllerBase
    {
        private readonly Social _social = social;

        // Need two endpoints 
        [HttpGet("GetMainSocialStats")]
        public ActionResult<List<SocialOverallDTO>> GetMainSocialStats ()
        {
            List<SocialOverallDTO> mainSocialList = _social.GetMainSocialStats();

            if(mainSocialList == null) return NoContent();

            return mainSocialList;

        }
        [HttpGet("GetDailySocialStats")]
        public ActionResult<List<DailyOverviewDTO>> GetDailySocialStats()
        {
            List<DailyOverviewDTO> dailySocialList = _social.GetDailySocialStats();

            if (dailySocialList == null) return NoContent();

            return dailySocialList;
        }
    }
}