using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GarbageCollectorTopic
{
    class TestGC
    {
        static void Main()
        {
            GC.TryStartNoGCRegion(1000 * 100000, true);

            //Allocate more than declared
            for (int i = 0; i < 1100; i++)
            {
                var arr = new byte[10000];
            }

            //Line below throws as it should
            try
            {
                System.GC.EndNoGCRegion();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //Not NoGCRegion
            Console.WriteLine(System.Runtime.GCSettings.LatencyMode);

            //Throws with "The NoGCRegion mode was already in progress
            Console.WriteLine(GC.TryStartNoGCRegion(1000 * 10000));

            Console.ReadLine();
        }
    }
}
