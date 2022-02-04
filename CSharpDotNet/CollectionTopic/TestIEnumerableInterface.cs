using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDotNet.CollectionTopic
{
    class TestIEnumerableInterface
    {
        static void TestForEachWithList()
        {
            EmployeeModel e1 = new EmployeeModel() { ID = 101, Name = "Jack", Job = "Software Developer", Salary = 50, IsActive = true };
            EmployeeModel e2 = new EmployeeModel() { ID = 102, Name = "Bruice", Job = "Sales", Salary = 41, IsActive = true };
            EmployeeModel e3 = new EmployeeModel() { ID = 103, Name = "McEntyre", Job = "Finance", Salary = 37, IsActive = true };
            EmployeeModel e4 = new EmployeeModel() { ID = 104, Name = "Brock", Job = "Manager", Salary = 31, IsActive = true };
            EmployeeModel e5 = new EmployeeModel() { ID = 105, Name = "Max", Job = "BAck Office", Salary = 17, IsActive = true };

            List<EmployeeModel> employeeList = new List<EmployeeModel>() { e1, e2, e3, e4, e5 };

            Console.WriteLine("TestForEachWithList \n");
            foreach (var emp in employeeList)
                Console.WriteLine($"ID: {emp.ID} ====> Name: {emp.Name} ====> Job: {emp.Job} ====> Salary: {emp.Salary} ====> IsActive: {emp.IsActive}");

            Console.WriteLine();
        }

        static void TestForEachWithUserDefinedCollection()
        {
            EmployeeModel e1 = new EmployeeModel() { ID = 101, Name = "Jack", Job = "Software Developer", Salary = 50, IsActive = true };
            EmployeeModel e2 = new EmployeeModel() { ID = 102, Name = "Bruice", Job = "Sales", Salary = 41, IsActive = true };
            EmployeeModel e3 = new EmployeeModel() { ID = 103, Name = "McEntyre", Job = "Finance", Salary = 37, IsActive = true };
            EmployeeModel e4 = new EmployeeModel() { ID = 104, Name = "Brock", Job = "Manager", Salary = 31, IsActive = true };
            EmployeeModel e5 = new EmployeeModel() { ID = 105, Name = "Max", Job = "BAck Office", Salary = 17, IsActive = true };

            OrganizationCollection employeeCollection = new OrganizationCollection();
            employeeCollection.Add(e1);
            employeeCollection.Add(e2);
            employeeCollection.Add(e3);
            employeeCollection.Add(e4);
            employeeCollection.Add(e5);

            Console.WriteLine("TestForEachWithUserDefinedCollection \n");
            foreach (EmployeeModel emp in employeeCollection)
                Console.WriteLine($"ID:  {emp.ID} ==> {emp.ID} ====> Name: {emp.Name} ====> Job: {emp.Job} ====> Salary: {emp.Salary} ====> IsActive: {emp.IsActive}");

            Console.WriteLine();

        }

        static void Main()
        {
            TestForEachWithList();
            Console.WriteLine("============================================================================");
            TestForEachWithUserDefinedCollection();
            Console.ReadLine();

        }
    };


    class EmployeeModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public bool IsActive { get; set; }

    }

    class OrganizationCollection : IEnumerable
    {
        List<EmployeeModel> employeeList = null;
        public OrganizationCollection()
        {
            this.employeeList = new List<EmployeeModel>();
        }

        public void Add(EmployeeModel emp)
        {
            employeeList.Add(emp);
        }

        /// <summary>
        /// Approach - 1
        /// </summary>
        /// <returns></returns>
        //public IEnumerator GetEnumerator()
        //{
        //    return employeeList.GetEnumerator();
        //}

        /// <summary>
        /// Approach - 2
        /// Write your own custom GetEnumerator and build logic to implement your class to behave like a List/Array
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }

        public int Count()
        {
            return employeeList.Count;
        }

        public EmployeeModel this[int index]
        {
            get
            {
                return employeeList[index];
            }
        } 
    }

    class OrganizationEnumerator : IEnumerator
    {
        // Before First <===
        // Emp 1
        // Emp 2
        // Emp 3
        // Emp 4
        // Emp 5
        // Emp 6
        // After Last

        OrganizationCollection OrganizationColl;
        EmployeeModel CurrentEmployee;
        int CurrentIndex;

        public OrganizationEnumerator(OrganizationCollection collection)
        {
            this.OrganizationColl = collection;
            CurrentIndex = -1;
        }

        public object Current
        {
            get
            {
                return CurrentEmployee;
            }
        }

        public bool MoveNext()
        {
            if (++CurrentIndex >= OrganizationColl.Count())
                return false;
            else
                CurrentEmployee = OrganizationColl[CurrentIndex];
            return true;

        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}


