using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Kakapo.DataAccess.Config
{
    public class RestSharpConfig
    {
        RestClient restClient;
        RestRequest restRequest;
        IRestResponse restResponse;

        public RestSharpConfig(string url, Method requestMethod){
            restClient = new RestClient(url);
            restRequest = new RestRequest(requestMethod);
            restRequest.AddHeader("User-Agent", "");
            restRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            restRequest.AddHeader("Accept-Language", "en-GB,en-US;q=0.9,en;q=0.8,vi;q=0.7");
            restRequest.AddHeader("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
        }

        public string ExcuteRequest()
        {
            restResponse = restClient.Execute(restRequest);
            return restResponse.Content;
        }
    }
}