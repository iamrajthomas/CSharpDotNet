using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.FreshDeskTicketSystem
{
    class Helper
    {
        public static bool WriteMyData(string payload, string fileName)
        {
            try
            {
                var DateFormat = string.Empty;
                DateFormat = DateTime.Now.ToString("dddd, dd MMMM yyyy");

                System.IO.File.AppendAllText(@"C:\\TFS\\FD\\" + fileName + "_" + DateFormat + "_" + ".log", payload);
            }
            catch (Exception ex)
            {
                return false;
                //throw;
            }

            return true;
        }
    }
}
