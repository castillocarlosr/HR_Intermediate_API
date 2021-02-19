using System.Collections.Generic;
using System.Text;
using System;
using System.Net.Http;
using HRapi2021.Constants;
using MediatR;

namespace HRapi2021.RequestHandlers
{
    public class HtpClientReqHan: IRequestHandler
    {
        public string GetReleases(string url)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add(RequestConstants.UserAgent, RequestConstants.UserAgentValue);

                var response = httpClient.GetStringAsync(new Uri(url)).Result;

                return response;
            }
        }
    }
}
