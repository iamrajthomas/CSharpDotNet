using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DoubleInNaN
{
    class TestDoubleInNaN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            TestReadDoubleData();
            Console.ReadLine();
        }

        public static void TestReadDoubleData()
        {
            string MessageToBeLogged = string.Empty;

            MessageToBeLogged = "START :: TestReadDoubleData() Method Invoked \n";
            PrintLog(MessageToBeLogged);

            MessageToBeLogged = string.Format("TestReadDoubleData :: ApplicationConfiguration.WorkflowEngineCacheAbsoluteExpiration: {1}, {0} RuleEngineCacheAbsoluteExpirationInHours: {2} {0}",
                Environment.NewLine,
                ApplicationConfiguration.WorkflowEngineCacheAbsoluteExpiration,
                ApplicationConfiguration.RuleEngineCacheAbsoluteExpiration);
            PrintLog(MessageToBeLogged);


            var WorkflowEngineCacheAbsoluteExpirationTimeSpan = !double.IsNaN(ApplicationConfiguration.WorkflowEngineCacheAbsoluteExpiration) && ApplicationConfiguration.WorkflowEngineCacheAbsoluteExpiration > 0 ? TimeSpan.FromHours(ApplicationConfiguration.WorkflowEngineCacheAbsoluteExpiration) : CacheHelper.Absolute10Hours;
            var RuleEngineCacheAbsoluteExpirationTimeSpan = !double.IsNaN(ApplicationConfiguration.RuleEngineCacheAbsoluteExpiration) && ApplicationConfiguration.RuleEngineCacheAbsoluteExpiration > 0 ? TimeSpan.FromHours(ApplicationConfiguration.RuleEngineCacheAbsoluteExpiration) : CacheHelper.Absolute10Hours;

            MessageToBeLogged = string.Format("TestReadDoubleData :: WorkflowEngineCacheAbsoluteExpirationTimeSpan: {1}, {0} RuleEngineCacheAbsoluteExpirationTimeSpan: {2} {0}",
                Environment.NewLine,
                WorkflowEngineCacheAbsoluteExpirationTimeSpan,
                RuleEngineCacheAbsoluteExpirationTimeSpan);
            PrintLog(MessageToBeLogged);
        }

        static void PrintLog(string messageToBeLogged)
        {
            Console.WriteLine(messageToBeLogged);
        }
    }

    public class ApplicationConfiguration
    {
        /// <summary>
        /// Gets the Workflow Engine Cache Absolute Expiration
        /// </summary>
        /// <returns></returns>
        public static double WorkflowEngineCacheAbsoluteExpiration
        {
            get
            {
                return 1024;
            }
        }

        /// <summary>
        /// Gets the Rule Engine Cache Absolute Expiration
        /// </summary>
        /// <returns></returns>
        public static double RuleEngineCacheAbsoluteExpiration
        {
            get
            {
                return 25100;
            }
        }
    }

    public sealed partial class CacheHelper
    {
        /// <summary>
        /// Absolute 10Hours expiration timespan.
        /// </summary>
        public static readonly TimeSpan Absolute10Hours = TimeSpan.FromHours(10);
    }
}
