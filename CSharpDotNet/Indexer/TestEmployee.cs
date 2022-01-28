using System;

namespace CSharpDotNet.Indexer
{
    class TestEmployee
    {
        static void Main()
        {
            TestEmployeeIndexer();

            Console.ReadLine();
        }

        public static void TestEmployeeIndexer()
        {
            Employee emp = new Employee(100, "Albert Hawkings", "Junior Developer", "Software", "Pune", 50000.00);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employee Data is being fetched (GET) with Employee[Index] and Printing it below: \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Here I can get the values of Employee just like an Array by using Index 
            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);
            Console.WriteLine(emp[5]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEmployee Data is being updated (SET) with Employee[Index] and Printing it \n");
            Console.ForegroundColor = ConsoleColor.Gray;


            //Here I can set the values of Employee just like an Array
            //Setting the value for employee object
            emp[1] = "William Johnsonn";
            emp[2] = "Senior Developer";
            emp[4] = "Mumbai";
            emp[5] = 100000.00;

            //Here getting the value after setting it above (updated value)
            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);
            Console.WriteLine(emp[5]);


            Console.WriteLine("=====================================================================================");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEmployee Data is being fetched (GET) with Employee[\"PropertyName\"] and Printing it \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Here I can get the values of Employee just like an Array by using PropertyName of the Employee Class
            Console.WriteLine(emp["EmployeeID"]);
            Console.WriteLine(emp["EmployeeName"]);
            Console.WriteLine(emp["Job"]);
            Console.WriteLine(emp["DepartmentName"]);
            Console.WriteLine(emp["Location"]);
            Console.WriteLine(emp["Salary"]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEmployee Data is being updated (SET) with Employee[\"PropertyName\"] and Printing it \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Here I can set the values of Employee just like an Array by using PropertyName of the Employee Class
            //Setting the value for employee object
            emp["EmployeeName"] = "Nicola Tesla";
            emp["Job"] = "Senior Manager";
            emp["Location"] = "LA";
            emp["Salary"] = 400000.00;

            //Here getting the value after setting it above (updated value)
            Console.WriteLine(emp["EmployeeID"]);
            Console.WriteLine(emp["EmployeeName"]);
            Console.WriteLine(emp["Job"]);
            Console.WriteLine(emp["DepartmentName"]);
            Console.WriteLine(emp["Location"]);
            Console.WriteLine(emp["Salary"]);


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=====================================================================================");

        }
    }
}
