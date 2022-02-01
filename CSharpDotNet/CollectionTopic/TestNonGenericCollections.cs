using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.CollectionTopic
{
    class TestNonGenericCollections
    {
        /// <summary>
        /// ArrayList
        /// </summary>
        public static void TestArrayList()
        {
            ArrayList arrayList = new ArrayList();
            //ArrayList arrayList = new ArrayList(5); // initial capacity = 5
            Console.WriteLine("ArrayList Capacity: " + arrayList.Capacity); //initial capacity = 0

            arrayList.Add(100);
            Console.WriteLine("ArrayList Capacity: " + arrayList.Capacity); //capacity = 4 //Auto-Resized
            arrayList.Add(200);
            arrayList.Add(300);
            arrayList.Add(400);
            Console.WriteLine("ArrayList Capacity: " + arrayList.Capacity); //capacity = 4

            arrayList.Add(500);
            Console.WriteLine("ArrayList Capacity: " + arrayList.Capacity);  //capacity = 8 //Auto-Resized

            Console.WriteLine("====================== Printing All Added Values ");

            foreach (object obj in arrayList)
                Console.Write(obj + "  ");

            Console.WriteLine();
            Console.WriteLine("====================== Inserted 350 at index position 3");

            arrayList.Insert(3, 350);
            foreach (object obj in arrayList)
                Console.Write(obj + "  ");

            Console.WriteLine();
            Console.WriteLine("====================== Deleted 200 from arrayList / index postion 1");

            //arrayList.Remove(200);
            arrayList.RemoveAt(1);
            foreach (object obj in arrayList)
                Console.Write(obj + "  ");



        }

        /// <summary>
        /// HashTable
        /// HashTable won't retain the sequence, because internally it makes use of HashCodes against the keys. So this is faster.
        /// Dictionary (Check GenericCollections) will retain the sequence.
        /// </summary>
        public static void TestHashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Id", 001);
            hashtable.Add("Createdby", "Hashtable Collection");
            hashtable.Add("Ename", "Alex William");
            hashtable.Add("Job", "Manager");
            hashtable.Add("Salary", 50000.00);
            hashtable.Add("Mgrid", 1005);
            hashtable.Add("Phone", "77987978989");
            hashtable.Add("Email", "alex@test.com");
            hashtable.Add("Dname", "Engineeering");
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Did", 55);

            Console.WriteLine(hashtable["Id"]);

            Console.WriteLine("=========================");
            Console.WriteLine();
            foreach (object key in hashtable.Keys)
                Console.WriteLine(key + ": " + hashtable[key] + " ==> hashCode: " + key.GetHashCode());

            Console.WriteLine("=========================");


        }

        /// <summary>
        /// Test Non-Generic Collection Disadvantages 
        /// </summary>
        public static void TestNonGenericCollectionDisadvantages()
        {
            Console.WriteLine("====================== Non-Generic Collections are not type safe ======================");

            ArrayList arrayList = new ArrayList();

            arrayList.Add(100);
            arrayList.Add("HELLO");
            arrayList.Add(300.00);
            arrayList.Add('C');
            arrayList.Add(true);

            Console.WriteLine("====================== Printing All Added Values");

            foreach (object obj in arrayList)
                Console.Write(obj + "  ");
        }

        static void Main()
        {
            //TestArrayList();
            //TestHashTable();
            TestNonGenericCollectionDisadvantages();
            Console.ReadLine();
        }
    }
}
