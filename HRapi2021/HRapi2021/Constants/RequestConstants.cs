using System;
using System.Collections.Generic;
using System.Text;

namespace HRapi2021.Constants
{
    public static class RequestConstants
    {
        public const string BaseUrl = "https://jsonmock.hackerrank.com";
        public const string Url = "https://jsonmock.hackerrank.com/api/football_matches?year=2011&team1=Barcelona&page=1";
        public static string ReturnPages(string team, int year) 
        {
            string temp = $"https://jsonmock.hackerrank.com/api/football_matches?"+year+"=2011&team1="+team+"&page=1";
            return temp;
        }


        public const string UserAgent = "User-Agent";
        public const string UserAgentValue = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36";
    }
}
