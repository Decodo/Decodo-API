using System;
using System.IO;
using System.Net;
using System.Text;

namespace Decodo_API
{
    class create_subuser
    {
        static void Main(string[] args)
        {
            // Details from authentication
            string userId = "";
            string token = "";

            string uri = "https://api.decodo.com/v1/users/" + userId + "/sub-users";

            // Change null accordingly to the parameter, if you want to create shared_proxy user change the service_type

            string data = "{\"username\":\"null\",\"password\":\"null\",\"traffic_limit\":null,\"service_type\":\"residential_proxies\"}";

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
