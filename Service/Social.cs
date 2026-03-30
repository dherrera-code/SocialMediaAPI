using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMediaAPI.Entities;

namespace SocialMediaAPI.Service
{
    public class Social
    {
        public List<SocialOverallDTO> GetMainSocialStats()
        {
            List<SocialOverallDTO> DataList = [];
            Random rand = new();

            SocialOverallDTO FacebookStats = new()
            {
                SocialMedia = "Facebook",
                Username = "DanTheMan",
                FollowerCount = rand.Next(1000, 7001),
                AddedFollowers = rand.Next(-110, 201),
            };
            DataList.Add(FacebookStats);

            SocialOverallDTO TwitterStats = new()
            {
                SocialMedia = "Twitter",
                Username = "DanTheMan",
                FollowerCount = rand.Next(1000, 9001),
                AddedFollowers = rand.Next(-50, 101),
            };
            DataList.Add(TwitterStats);
            
            SocialOverallDTO InstagramStats = new()
            {
                SocialMedia = "Twitter",
                Username = "@DanTHeMAN",
                FollowerCount = rand.Next(3000, 12001),
                AddedFollowers = rand.Next(-210, 251),
            };
            DataList.Add(InstagramStats);

            SocialOverallDTO YoutubeStats = new()
            {
                SocialMedia = "Youtube",
                Username = "DanTheMan",
                FollowerCount = rand.Next(10000, 30001),
                AddedFollowers = rand.Next(-510, 1001),
            };
            DataList.Add(YoutubeStats);

            return DataList;
        }

        public List<DailyOverviewDTO> GetDailySocialStats()
        {
            List<DailyOverviewDTO> DataList = [];
            Random rand = new();

            DailyOverviewDTO FacebookViews = new()
            {
                SocialMedia = "Facebook",
                ViewsOrLikes = "Page Views",
                Amounts = rand.Next(5,301),
                TrendingPercentage = rand.Next(-201, 501)
            };
            DataList.Add(FacebookViews);

            DailyOverviewDTO FacebookLikes = new()
            {
                SocialMedia = "Facebook",
                ViewsOrLikes = "Likes",
                Amounts = rand.Next(5,301),
                TrendingPercentage = rand.Next(-201, 501)
            };
            DataList.Add(FacebookLikes);

            DailyOverviewDTO TwitterLikes = new()
            {
                SocialMedia = "Twitter",
                ViewsOrLikes = "Likes",
                Amounts = rand.Next(5, 401),
                TrendingPercentage = rand.Next(-201, 501)  
            };
            DataList.Add(TwitterLikes);

            DailyOverviewDTO TwitterViews = new()
            {
                SocialMedia = "Twitter",
                ViewsOrLikes = "Retweets",
                Amounts = rand.Next(5, 401),
                TrendingPercentage = rand.Next(-201, 501)  
            };
            DataList.Add(TwitterViews);

            DailyOverviewDTO InstagramLikes = new()
            {
                SocialMedia = "Instagram",
                ViewsOrLikes = "Likes",
                Amounts = rand.Next(5, 500),
                TrendingPercentage = rand.Next(-104, 101)
            };
            DataList.Add(InstagramLikes);

            DailyOverviewDTO InstagramViews = new()
            {
                SocialMedia = "Instagram",
                ViewsOrLikes = "Profile Views",
                Amounts = rand.Next(5, 800),
                TrendingPercentage = rand.Next(-104, 101)
            };
            DataList.Add(InstagramViews);

            DailyOverviewDTO YoutubeLikes = new()
            {
                SocialMedia = "Youtube",
                ViewsOrLikes = "Likes",
                Amounts = rand.Next(100, 5001),
                TrendingPercentage = rand.Next(-100,101)
            };
            DataList.Add(YoutubeLikes);

            DailyOverviewDTO YoutubeViews = new()
            {
                SocialMedia = "Youtube",
                ViewsOrLikes = "Total Views",
                Amounts = rand.Next(100, 6001),
                TrendingPercentage = rand.Next(-100,101)
            };
            DataList.Add(YoutubeViews);

            return DataList;
        }
    }
}