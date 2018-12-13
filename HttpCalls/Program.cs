using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumePosts();

            Console.ReadKey();
        }

        private async static void ConsumePosts()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("APIKEY");
            string json = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            var objs = JsonConvert.DeserializeObject(json);

            httpClient.PostAsync("POST" , new StringContent())
        }
    }
}
