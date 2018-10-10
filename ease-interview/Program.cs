using RestSharp;
using System;

namespace EaseInterview {

    class Program {

        private static string TOKEN = "xaVSCVwAdCbv8R4oIMdEcQh7e";
        private static string SECRET = "V-Q0K7aZun7xQEd_poq59ExsMb-HATYM6Ec-";

        static void Main(string[] args) {

            // Connect to API
            var client = new RestClient("https://data.sfgov.org");
            var request = new RestRequest("resource/9a6x-abyp.json", Method.GET);
            request.AddHeader("X-App-Token", TOKEN);

            //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            Console.WriteLine(content);



            // TODO

                                 

            /* Write Hello World to CSV file
            var csv = new StringBuilder();

            var newLine = $"Hello,World";
            csv.AppendLine(newLine);

            File.WriteAllText(@"C:\tmp\test.csv", csv.ToString());
            */
        }
    }
}
