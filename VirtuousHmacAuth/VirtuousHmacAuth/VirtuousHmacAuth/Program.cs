using System;
using System.Net.Http;

namespace VirtuousHmacAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            var virtuousApi = "https://api.virtuoussoftware.com";

            var applicationKey = "REPLACE_ME";

            var requestMethod = "POST";
            var requestUrl = "/api/gift/transaction/";

            var virtuousHmacAuth = new VirtuousHmacAuth();
            var hmacHeader = virtuousHmacAuth.GenerateHmacHeader(applicationKey, requestMethod, requestUrl);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(virtuousApi);
            client.DefaultRequestHeaders.Add("Authorization", hmacHeader);
            client.DefaultRequestHeaders.Add("Content-Type", "application/json");

            StringContent postData = new StringContent("{ id: \"Some Json Object\" }");

            var postAsync = client.PostAsync(requestUrl, postData);
            postAsync.RunSynchronously();
            var result = postAsync.Result;

            Console.WriteLine("Status Code: {0}", result.StatusCode);
            Console.WriteLine("Content: {0}", result.Content);
        }
    }
}
