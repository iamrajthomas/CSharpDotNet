using System;
using System.Net;
using System.Text;
using System.IO;

namespace CSharpDotNet.FreshDeskTicketSystem
{
    public static class GetTicketById
    {
        public static void Invoke(string ticket = "230792")
        {
            string fdDomain = FDConstant.fdDomain; // fdDomain 
            string apiKey = FDConstant.apiKey; // apiKey
            string apiPath = FDConstant.apiPath + ticket; // API path

            string responseBody = String.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://" + fdDomain + ".freshdesk.com" + apiPath);
            request.ContentType = "application/json";
            request.Method = "GET";
            string authInfo = apiKey + ":X"; // It could be your username:password also.
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            request.Headers["Authorization"] = "Basic " + authInfo;
            try
            {
                Console.WriteLine("Submitting Request");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    responseBody = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                    //return status code
                    Console.WriteLine("Status Code: {1} {0}", ((HttpWebResponse)response).StatusCode, (int)((HttpWebResponse)response).StatusCode);
                }
                Console.Out.WriteLine(responseBody);


                //Writing all data to external file
                var IsSuccess = Helper.WriteMyData(responseBody, "FD_" + ticket);
                Console.Out.WriteLine(IsSuccess);
            }
            catch (WebException ex)
            {
                Console.WriteLine("API Error: Your request is not successful. If you are not able to debug this error properly, mail us at support@freshdesk.com with the follwing X-Request-Id");
                Console.WriteLine("X-Request-Id: {0}", ex.Response.Headers["X-Request-Id"]);
                Console.WriteLine("Error Status Code : {1} {0}", ((HttpWebResponse)ex.Response).StatusCode, (int)((HttpWebResponse)ex.Response).StatusCode);
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    Console.Write("Error Response: ");
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
