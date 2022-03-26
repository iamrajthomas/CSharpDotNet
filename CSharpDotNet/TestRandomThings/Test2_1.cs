using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.TestRandomThings
{
    class Test2_1
    {
        static void Main()
        {
            GetCallAPI();

        }

        private static void GetCallAPI()
        {
            string Url = "https://jsonplaceholder.typicode.com/posts";

            WebRequest request = WebRequest.Create(Url);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string ResultResponse = null;
            using(Stream st = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(st);
                ResultResponse = sr.ReadToEnd();
                sr.Close();
            }

        }
    }
}
