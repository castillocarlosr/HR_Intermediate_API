using HRapi2021.Constants;
using HRapi2021.Model;
using HRapi2021.RequestHandlers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace HRapi2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CARLOS!");
            //string input = Console.ReadLine();
            //Console.WriteLine($"Your input:  {input}");

            MediatR.IRequestHandler htpClientRhandler = new HtpClientReqHan();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var respTwo = GetReleases(htpClientRhandler);
            var githubReTwo = JsonConvert.DeserializeObject<Football>(respTwo);

            //foreach (var release in githubReTwo)
            //{
            //    Console.WriteLine("Team1 : {0}", release.Team1);
            //    Console.WriteLine();
            //}
            Console.WriteLine("OHHHHH " + githubReTwo.TotalPages + "WEEEEEE");
            Console.ReadLine();
        }

        public static string GetReleases(MediatR.IRequestHandler requestHandler)
        {
            return requestHandler.GetReleases(RequestConstants.Url);
        }
    }
}
