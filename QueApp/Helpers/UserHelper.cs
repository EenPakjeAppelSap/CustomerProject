using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QueApp.Helpers
{
    public class UserHelper
    {
        public static string GetUser()
        {
            var request = WebRequest.Create("https://stemmachine.azurewebsites.net/api/GetParty?code=vNX2uVSyNFCmAhsIoIsinwYaZWwCSVXVprr8nkpTbmyukvhEO5nrdg==");
            request.ContentType = "application/json";
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }


        public static Model.UserModel UserLogin(string email, string password)
        {

            var request = WebRequest.Create("https://queapp.azurewebsites.net/api/GetStudent?code=2yYOItB3nY9rvYIaMhD20PSKwZDtttzcXdoaihhcuwcC7Sl6i6n8NQ==");
            request.ContentType = "application/json";
            request.Method = "POST";

            var encryptedPassword = sha256(password);

            var getLoginRequest = new
            {
                Email = email,
                Password = encryptedPassword
            };
            var data = JsonConvert.SerializeObject(getLoginRequest).ToString();
            using (var writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.WriteLine(data);
            }
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return JsonConvert.DeserializeObject<Model.UserModel>(responseString);
        }

        static string sha256(string passwordString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(passwordString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

    }
}
