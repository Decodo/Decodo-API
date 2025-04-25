using System;
using System.IO;
using System.Net;

namespace Decodo_API
{
    class get_whitelisted_ips
    {
        static void Main(string[] args)
        {
            // Details from authentication
            string userId = "";
            string token = "";

            string uri = "https://api.decodo.com/v1/users/" + userId + "/whitelisted-ips";

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
