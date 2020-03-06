using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tutorial1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //int? g = null;
            //int b = true;
            //string str = "small s is an allias";

            //int age = 5;

            //Console.WriteLine($"I am {5} years old.");
            //Console.WriteLine("Hello World!");

            var url = @"https://www.pja.edu.pl";
            using (var httpClient = new HttpClient())
            {

                //var response = await httpClient.GetAsync(url);
                using (var response = await httpClient.GetAsync(url))
                {
                    var content = await response.Content.ReadAsStringAsync();

                    //response.Dispose();

                    var regex = new Regex("[a-z]+[a-z+-9]*@[a-z]+\\.[a-z]+", RegexOptions.IgnoreCase);
                    var matches = regex.Matches(content);
                    foreach (var item in matches)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
        }
    }
}
