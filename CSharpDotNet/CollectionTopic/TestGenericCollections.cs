using System;
using System.Collections.Generic;

namespace CSharpDotNet.CollectionTopic
{
    class TestGenericCollections
    {
        /// <summary>
        /// Test List
        /// </summary>
        static void TestList()
        {
            // List<T> list = new List<T>(); //T refers to Type (both pre-defined/ user-defined)
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            // Simplified Version of Adding List
            //List<int> list = new List<int>
            //{
            //    10,
            //    20,
            //    30,
            //    40,
            //    50
            //};

            list.Insert(1, 15);
            list.Remove(40);
            //list.RemoveAt(5);

            foreach (int i in list)
                Console.Write(i + "  ");

            Console.WriteLine();
        }

        /// <summary>
        /// TestList With UserDefined Type
        /// </summary>
        static void TestListWithUserDefinedType() 
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            CustomerModel c1 = new CustomerModel() { ID = 1, Name = "Scott", Email = "scott@test.com", CreatedAt = DateTime.Now, Phone = "455465456465", IsActive = true };
            CustomerModel c2 = new CustomerModel() { ID = 2, Name = "David", Email = "david@test.com", CreatedAt = DateTime.Now, Phone = "887989789798", IsActive = true };
            CustomerModel c3 = new CustomerModel() { ID = 3, Name = "Maxx", Email = "maxx@test.com", CreatedAt = DateTime.Now, Phone = "1321321313", IsActive = true };

            customerList.Add(c1);
            customerList.Add(c2);
            customerList.Add(c3);

            foreach (CustomerModel c in customerList)
                Console.WriteLine("ID: " + c.ID + " Name: " + c.Name + " Email: " + c.Email + " CreatedAt: " + c.CreatedAt + " Phone: " + c.Phone + " IsActive: " + c.IsActive);

            Console.WriteLine();
        }

        /// <summary>
        /// TestDictionary
        /// HashTable won't retain the sequence (Check Non-GenericCollections), because internally it makes use of HashCodes against the keys. So this is faster.
        /// Dictionary retains the sequence.
        /// </summary>
        static void TestDictionary()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Id", 001);
            dict.Add("Createdby", "Dictionary Collection");
            dict.Add("Ename", "Alex William");
            dict.Add("Job", "Manager");
            dict.Add("Salary", 50000.00);
            dict.Add("Mgrid", 1005);
            dict.Add("Phone", "77987978989");
            dict.Add("Email", "alex@test.com");
            dict.Add("Dname", "Engineeering");
            dict.Add("Location", "Mumbai");
            dict.Add("Did", 55);

            foreach (var d in dict)
                Console.WriteLine(d.Key + " : " + d.Value);

            Console.WriteLine("============================");
            Console.WriteLine();

            foreach (string key in dict.Keys)
                Console.WriteLine(key + " : " + dict[key]);

        }



        /// <summary>
        /// TestList With UserDefined Type
        /// </summary>
        static void TestDictionaryWithUserDefinedType()
        {
            Dictionary<string, CustomerModel> customerDict = new Dictionary<string, CustomerModel>();

            CustomerModel c1 = new CustomerModel() { ID = 7, Name = "Edward", Email = "edward@test.com", CreatedAt = DateTime.Now, Phone = "56545665566", IsActive = true };
            CustomerModel c2 = new CustomerModel() { ID = 8, Name = "Olivia", Email = "olivia@test.com", CreatedAt = DateTime.Now, Phone = "54647988888", IsActive = true };
            CustomerModel c3 = new CustomerModel() { ID = 9, Name = "Brian", Email = "brian@test.com", CreatedAt = DateTime.Now, Phone = "6654878512313", IsActive = true };

            customerDict.Add("Edward", c1);
            customerDict.Add("Olivia", c2);
            customerDict.Add("Brian", c3);

            foreach (KeyValuePair<string, CustomerModel> c in customerDict)
                Console.WriteLine("ID: " + c.Value.ID + " Name: " + c.Value.Name + " Email: " + c.Value.Email + " CreatedAt: " + c.Value.CreatedAt + " Phone: " + c.Value.Phone + " IsActive: " + c.Value.IsActive);

            Console.WriteLine("===================================");

            foreach (string key in customerDict.Keys)
                Console.WriteLine("ID: " + customerDict[key].ID + " Name: " + customerDict[key].Name + " Email: " + customerDict[key].Email + " CreatedAt: " + customerDict[key].CreatedAt + " Phone: " + customerDict[key].Phone + " IsActive: " + customerDict[key].IsActive);

            Console.WriteLine();
        }

        static void Main()
        {
            //TestList();
            Console.WriteLine("===================================");
            //TestDictionary();
            Console.WriteLine("===================================");
            TestListWithUserDefinedType();
            Console.WriteLine("===================================");
            TestDictionaryWithUserDefinedType();
            Console.WriteLine("===================================");
            Console.ReadLine();
        }
    }

    class CustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
    }
}
