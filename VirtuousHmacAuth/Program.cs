using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;

namespace VirtuousHmacAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            var virtuousApi = ConfigurationManager.AppSettings["VIRTUOUS_API"];
            var requestMethod = "POST";
            var requestUrl = "/api/v2/gift/transaction/";

            var applicationKey = ConfigurationManager.AppSettings["VIRTUOUS_CUSTOMER_APPLICATION_KEY"];

            var virtuousHmacAuth = new VirtuousHmacAuth();
            var hmacHeader = virtuousHmacAuth.GenerateHmacHeader(applicationKey, requestMethod, requestUrl);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(virtuousApi);
            client.DefaultRequestHeaders.Add("Authorization", hmacHeader);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var giftTransaction = new GiftTransaction()
            {
                TransactionId = Guid.NewGuid().ToString(),
                Contact = new Contact()
                {
                    Firstname = "Bob",
                    Lastname = "Loblaw"
                },
                GiftDate = DateTime.Now.ToShortDateString(),
                GiftType = "Credit",
                Amount = "50.00",
                CreditCardType = "Visa"
            };

            var giftTransactionJson = JsonConvert.SerializeObject(giftTransaction);

            StringContent postData = new StringContent(giftTransactionJson, System.Text.Encoding.UTF8, "application/json");

            var result = client.PostAsync(requestUrl, postData).Result;

            Console.WriteLine("Status Code: {0}", result.StatusCode);
            Console.WriteLine("Content: {0}", result.Content);
        }
    }
}
