using System;
using System.IO;
using System.Net;

namespace Decodo_API
{
    class delete_subuser
    {
        static void Main(string[] args)
        {
            // Details from authentication
            string userId = "";
            string token = "";
            int sub_user_id = null; // Recieved from get_subusers.cs

            string uri = "https://api.decodo.com/v1/users/" + userId + "/sub-users/" + sub_user_id;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Token " + token);
            request.ContentType = "application/json";
            request.Method = "DELETE";

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
