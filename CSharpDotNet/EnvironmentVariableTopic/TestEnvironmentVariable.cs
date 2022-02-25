using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.EnvironmentVariableTopic
{
    public class TestEnvironmentVariable
    {
        static void Main()
        {
            string Env = GetEnvVariableData();
            Console.WriteLine("ENVIRONMENT: " + Env);
            SetEnvVariableData();

            Env = GetEnvVariableData();
            Console.WriteLine("ENVIRONMENT: " + Env);

            Console.ReadLine();
        }

        private static void SetEnvVariableData()
        {
            System.Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development", EnvironmentVariableTarget.User);
        }

        private static string GetEnvVariableData()
        {
            return System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        }
    }
}
