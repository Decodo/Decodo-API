using System;
using System.IO;
using System.Net;
using System.Text;

namespace Decodo_API
{
    class add_whitelisted_ips
    {
        static void Main(string[] args)
        {
            // Details from authentication
            string userId = "";
            string token = "";

            string data = "{\"IPAddressList\":[\"26.41.42.124\",\"56.14.14.124\"]}"; // You can add as much as you want, and 1 IP addition is also possible.

            string uri = "https://api.decodo.com/v1/users/" + userId + "/whitelisted-ips";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Token " + token);
            request.ContentType = "application/json";
            request.ContentLength = dataBytes.Length;
            request.Method = "POST";

            using (Stream requestBody = request.GetRequestStream())
            {
                requestBody.Write(dataBytes, 0, dataBytes.Length);
            }

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
