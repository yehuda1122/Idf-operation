using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
namespace httpClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
                    response.EnsureSuccessStatusCode();
                    

                    string rasponseBody  = await response.Content.ReadAsStringAsync();
                    

                    var posts = JsonSerializer.Deserialize<List<Dictionary<string,object>>>(rasponseBody);

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"{posts[i]["title"]}");
                    }

                }

                catch (Exception ex)
                {

                }
                

           }
            
        }
    }
}
