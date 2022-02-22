using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.LINQ
{
    class DeferredAndImmediateExecution
    {
        static void Main()
        {
            TestDeferredExecution();
            Console.WriteLine("===================================");

            TestImmediateExecution();
            Console.ReadLine();

        }

        private static void TestDeferredExecution()
        {
            List<HumanBeing> humanBeings = new List<HumanBeing>();
            humanBeings.Add(new HumanBeing(101, "Alex", 25));
            humanBeings.Add(new HumanBeing(102, "Martina", 21));
            humanBeings.Add(new HumanBeing(103, "Williams", 24));
            humanBeings.Add(new HumanBeing(104, "Jerry", 28));

            //LINQ Query is created but is not executed here
            var filteredHumanBeings = humanBeings.Where(x => x.Age > 26).Select(y => y.Name);

            //Created another humanbeing post LINQ query is constructed
            humanBeings.Add(new HumanBeing(105, "Bruce", 27));

            foreach (var human in filteredHumanBeings) //LINQ Query executes here
            {
                Console.Write(human + " -- "); // Output: Jerry -- Bruce
            }
        }

        private static void TestImmediateExecution()
        {
            List<HumanBeing> humanBeings = new List<HumanBeing>();
            humanBeings.Add(new HumanBeing(101, "Alex", 25));
            humanBeings.Add(new HumanBeing(102, "Martina", 21));
            humanBeings.Add(new HumanBeing(103, "Williams", 24));
            humanBeings.Add(new HumanBeing(104, "Jerry", 28));

            //LINQ Query is created as well as executed here 
            //since aggregate operators or element operators (ToList(), ToDictionary(), ToArray() etc.) is called
            var filteredHumanBeings = humanBeings.Where(x => x.Age > 26).Select(y => y.Name).ToList();

            //Created another humanbeing post LINQ query is constructed
            humanBeings.Add(new HumanBeing(105, "Bruce", 27));

            foreach (var human in filteredHumanBeings)
            {
                Console.Write(human + " -- "); // Output: Jerry 
            }
        }

        private class HumanBeing
        {
            public HumanBeing(int _ID, string _Name, int _Age)
            {
                ID = _ID;
                Name = _Name;
                Age = _Age;
            }
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
