using System;
using System.IO;
using System.Net;

namespace Decodo_API
{
    class get_subuser_traffic
    {
        static void Main(string[] args)
        {
            // Details from authentication
            string userId = "";
            string token = "";

            string username = ""; // Subuser name
            string queryParam = ""; // Available types: 24h, month, 7days, custom. If custom type is selected, you must provide from and to parameters.

            string uri = "https://api.decodo.com/v1/users/" + userId + "/sub-users/" + username + "/traffic?type=" + queryParam;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Token " + token);
            request.ContentType = "application/json";
            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                Console.WriteLine(reader.ReadToEnd());
                Console.ReadKey();
            }
        }
    }
}
