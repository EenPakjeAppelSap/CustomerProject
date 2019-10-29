using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QueApp
{
    class QuestionHelper
    {
        private static string UserLogin()
        {
            var request = WebRequest.Create("https://stemmachine.azurewebsites.net/api/GetParty?code=vNX2uVSyNFCmAhsIoIsinwYaZWwCSVXVprr8nkpTbmyukvhEO5nrdg==");
            request.ContentType = "application/json";
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }

        //private static string SetQuestion()
        //{
        //    var request = WebRequest.Create("https://queapp.azurewebsites.net/api/SetQuestion?code=xbd/hedegNoJq0reGeTI1SaTk8S0LvCjbPsev2Nc1xr6tmYl14UtnA==");
        //    request.ContentType = "application/json";
        //    request.Method = "POST";
        //    var response = (HttpWebResponse)request.GetResponse();

        //    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        //    return responseString;
        //}

        private static void SetQuestion(string candidateNumber, string partyNumber)
        {
            var request = WebRequest.Create("https://queapp.azurewebsites.net/api/SetQuestion?code=xbd/hedegNoJq0reGeTI1SaTk8S0LvCjbPsev2Nc1xr6tmYl14UtnA==");
            request.ContentType = "application/json";
            request.Method = "POST";

            var questionRequest = new 
            {
                CandidateNumber = candidateNumber,
                PartyNumber = partyNumber
            };
            var data = JsonConvert.SerializeObject(setQuestionRequest).ToString();
            using (var writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.WriteLine(data);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

    }
}
