﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        
        static async Task Main(string[] args)
        {
            Console.WriteLine("Like all modern .NET APIs, HttpClient supports only async methods for its long-running APIs.");
            Console.WriteLine(" Start by making an async method. ");
            
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            /*
             * starter code to test full API string call
            var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            var stringTask2 = client.GetStringAsync("https://jsonmock.hackerrank.com/api/football_matches?year=2011&team1=Barcelona&page=1");
            */
            Console.WriteLine("TESSSSSTTTTTTTTTTTTTTTTTT!!!!!!!!!!HERE");
            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);
            var streamTask2 = client.GetStreamAsync("https://jsonmock.hackerrank.com/api/football_matches?year=2011&team1=Barcelona&page=1");
            var repositories2 = await JsonSerializer.DeserializeAsync<Repos2>(await streamTask2);

            /*
            var msg = await stringTask2;
            Console.Write(msg);
            */

            //foreach (var item in repositories)
            //{
            //    Console.WriteLine(item.name);
            //}
            Console.WriteLine("page  "+ repositories2.page);
            Console.WriteLine("total pages  "+ repositories2.total_pages);
            Console.WriteLine("team goals   "+repositories2.team1goals);
        }
    }
}
