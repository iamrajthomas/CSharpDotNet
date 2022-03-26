using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.TestRandomThings
{
    class Test1
    {

        static void Main()
        {
            int i = 10;
            string s = "Hello";
            Stack s1 = new Stack();
        }
    }

    class Test2
    {

        static void Main()
        {
            TestSimpleJoin();

            TestComplexJoin();

            TestComplexJoinWithGroupBy();

            TestCoalesce();
        }

        private static void TestCoalesce()
        {
            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = null;
            string str5 = null; // "Some Value Here";
            string str6 = null;

            var result = str1 ?? str2 ?? str3 ?? str4 ?? str5 ?? str6;

        }

        private static void TestComplexJoinWithGroupBy()
        {
            IList<Client> clientList = new List<Client>() {
                new Client() { ID = 1, Name = "MS", LocationId = 1 },
                new Client() { ID = 2, Name = "Google", LocationId = 1 },
                new Client() { ID = 3, Name = "Harman", LocationId = 1 },
                new Client() { ID = 4, Name = "Accenture", LocationId = 2 },
                new Client() { ID = 5, Name = "TCS", LocationId = 2 },
                new Client() { ID = 6, Name = "TechM", LocationId = 3 },
                new Client() { ID = 7, Name = "InfoVision", LocationId = 3 },
                new Client() { ID = 8, Name = "CTS", LocationId = 4 },
            };

            IList<Location> locationList = new List<Location>() {
                new Location(){ ID = 1, Name ="US"},
                new Location(){ ID = 2, Name ="India"},
                new Location(){ ID = 3, Name ="Canada"},
                new Location(){ ID = 4, Name ="Australia"},
            };

            var myResult = clientList.GroupBy(x => x.LocationId).Join(locationList,
                    clientGroupedBy => clientGroupedBy.Key,
                    location => location.ID,
                    (clientGroupedBy, location) => new
                    {
                        LocationName = location.Name,
                        Clients = clientGroupedBy.ToList()
                    }); 

            var myResult2 = locationList.Join(clientList.GroupBy(x => x.LocationId),
                location => location.ID,
                client => client.Key,
                (location, client) => new 
                {
                    LocationName = location.Name,
                    Clients = client.ToList()
                });

            //Console.ReadLine();

        }


        private static void TestComplexJoin()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { ID = 1, Name = "John", StandardID =1 },
                new Student() { ID = 2, Name = "Moin", StandardID =1 },
                new Student() { ID = 3, Name = "Bill", StandardID =2 },
                new Student() { ID = 4, Name = "Ram" , StandardID =2 },
                new Student() { ID = 5, Name = "Ron"  }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ ID = 1, StandardName="Standard 1"},
                new Standard(){ ID = 2, StandardName="Standard 2"},
                new Standard(){ ID = 3, StandardName="Standard 3"}
            };

            var joinResult = studentList.Join(
                standardList,
                student => student.StandardID,
                standard => standard.ID,
                (student, standard) => new
                {
                    StudentName = student.Name,
                    Standard = standard.ID
                });

            //Console.ReadLine();

        }

        private static void TestSimpleJoin()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four" };
            IList<string> strList2 = new List<string>() { "One", "Two", "Five", "Six" };

            //Query to get the common values from both List

            var InnerJoinRes = strList1.Join(strList2,
                        str1 => str1,
                        str2 => str2,
                        (str1, str2) => str2);

            //Console.ReadLine();
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int ID { get; set; }
        public string StandardName { get; set; }
    }

    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
    }

    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
