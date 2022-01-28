using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.FreshDeskTicketSystem
{
    public static class Startup
    {
        public static void Invoke()
        {
            //GetAllTickets.Invoke();
            
            GetTicketById.Invoke();

            Console.ReadLine();

        }
    }
}
