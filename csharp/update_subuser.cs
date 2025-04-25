using System;
using System.IO;
using System.Net;
using System.Text;

namespace Decodo_API
{
    class update_subuser
    {
        static void Main(string[] args)
        {
            // Details from authentication
            string userId = "";
            string token = "";
            int sub_user_id = null; // Recieved from get_subusers.cs

            string uri = "https://api.decodo.com/v1/users/" + userId + "/sub-users/" + sub_user_id;

            // Change null accordingly to the parameter
            string data = "{\"traffic_limit\":null,\"password\":\"null\"}";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Token " + token);
            request.ContentType = "application/json";
            request.ContentLength = dataBytes.Length;
            request.Method = "PUT";

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
