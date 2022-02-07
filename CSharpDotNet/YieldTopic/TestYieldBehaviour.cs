using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.YieldTopic
{
    class TestYieldBehaviour
    {
        public void Invoke()
        {
            List<int> numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Appraoch - 1
            // Here the complete running total is calculated and retured at once
            // results printed once the calculation is completed for the entire list
            var data = CalculateRunningTotal(numList);
            foreach (var item in data)
            {
                Console.WriteLine("item: " + item);
            }

            // Appraoch - 2
            // Here the running total is calculated and retured one at a time
            // results printing doens't need to wait till all the calculation is completed for the entire list
            foreach (var item in CalculateRunningTotalUsingYield(numList))
            {
                Console.WriteLine("item: " + item);
            }
            Console.ReadLine();

        }
        public IEnumerable<int> CalculateRunningTotalUsingYield(List<int> numList)
        {
            var total = 0;

            for (int i = 1; i < numList.Count; i++)
            {
                total += numList[i];
                yield return total;
            }
        }

        public List<int> CalculateRunningTotal(List<int> numList)
        {
            List<int> tempList = new List<int>();
            var total = 0;
            for (int i = 1; i < numList.Count; i++)
            {
                total += numList[i];
                tempList.Add(total);
            }
            return tempList;
        }

        static void Main()
        {
            TestYieldBehaviour testYieldBehaviour = new TestYieldBehaviour();
            testYieldBehaviour.Invoke();
        }
    }
}
