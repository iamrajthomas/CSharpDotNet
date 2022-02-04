using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDotNet.CollectionTopic
{
    class TestIEnumerableInterfaceWithGenerics
    {
        static void TestForEachWithList()
        {
            EngineerModel eng1 = new EngineerModel() { ID = 101, Name = "Jack", Skill = ".NET", IsActive = true };
            EngineerModel eng2 = new EngineerModel() { ID = 102, Name = "Monty", Skill = "JAVA", IsActive = true };
            EngineerModel eng3 = new EngineerModel() { ID = 103, Name = "Paul", Skill = "Cloud Computing", IsActive = true };
            EngineerModel eng4 = new EngineerModel() { ID = 104, Name = "Kelie", Skill = "Azure", IsActive = true };
            EngineerModel eng5 = new EngineerModel() { ID = 105, Name = "Brian", Skill = "JavaScript", IsActive = true };
            EngineerModel eng6 = new EngineerModel() { ID = 106, Name = "Aldrin", Skill = "UI UX", IsActive = true };

            List<EngineerModel> employeeList = new List<EngineerModel>() { eng1, eng2, eng3, eng4, eng4, eng5, eng6 };

            Console.WriteLine("TestForEachWithList (List<T>): \n");
            foreach (var emp in employeeList)
                Console.WriteLine($"ID: {emp.ID} ====> Name: {emp.Name} ====> Skill: {emp.Skill} ====> IsActive: {emp.IsActive}");

            Console.WriteLine();
        }

        static void TestForEachWithUserDefinedGenericCollection()
        {
            EngineerModel eng1 = new EngineerModel() { ID = 101, Name = "Jack", Skill = ".NET", IsActive = true };
            EngineerModel eng2 = new EngineerModel() { ID = 102, Name = "Monty", Skill = "JAVA", IsActive = true };
            EngineerModel eng3 = new EngineerModel() { ID = 103, Name = "Paul", Skill = "Cloud Computing", IsActive = true };
            EngineerModel eng4 = new EngineerModel() { ID = 104, Name = "Kelie", Skill = "Azure", IsActive = true };
            EngineerModel eng5 = new EngineerModel() { ID = 105, Name = "Brian", Skill = "JavaScript", IsActive = true };
            EngineerModel eng6 = new EngineerModel() { ID = 106, Name = "Aldrin", Skill = "UI UX", IsActive = true };

            CorporateCollection<EngineerModel> corporateColl = new CorporateCollection<EngineerModel>();

            corporateColl.Add(eng1);
            corporateColl.Add(eng2);
            corporateColl.Add(eng3);
            corporateColl.Add(eng4);
            corporateColl.Add(eng5);
            corporateColl.Add(eng6);

            //List<EngineerModel> employeeList = new List<EngineerModel>() { eng1, eng2, eng3, eng4, eng4, eng5, eng6 };

            Console.WriteLine("TestForEachWithUserDefinedGenericCollection (CorporateCollection<T>): \n");
            foreach (EngineerModel corporate in corporateColl)
                Console.WriteLine($"ID: {corporate.ID} ====> Name: {corporate.Name} ====> Skill: {corporate.Skill} ====> IsActive: {corporate.IsActive}");

            Console.WriteLine();
        }

        static void Main()
        {
            TestForEachWithList();
            Console.WriteLine("============================================================================");
            TestForEachWithUserDefinedGenericCollection();
            Console.WriteLine("============================================================================");
            Console.ReadLine();
        }
    }

    class EngineerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public bool IsActive { get; set; }
    }


    class CorporateCollection<T> : IEnumerable<T>
    {
        List<T> corporateCollections = null;

        public CorporateCollection()
        {
            corporateCollections = new List<T>();
        }

        public void Add(T engineer)
        {
            corporateCollections.Add(engineer);
        }

        /// <summary>
        /// Approach - 1 
        /// </summary>
        /// <returns></returns>
        //public IEnumerator GetEnumerator()
        //{
        //    return corporateCollections.GetEnumerator();
        //}

        public IEnumerator GetEnumerator()
        {
            return new CorporateEnumerator<T>(this);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new CorporateEnumerator<T>(this);
        }

        public int Count()
        {
            return corporateCollections.Count;
        }

        public T this[int index]
        {
            get
            {
                return corporateCollections[index];
            }
        }
    }

    class CorporateEnumerator<T> : IEnumerator<T>
    {
        T CurrentEngineer;
        CorporateCollection<T> CorporateColl;
        int CurrentIndex;
        bool _disposed = false;
        bool disposing = false;

        // Before First <===
        // Emp 1
        // Emp 2
        // Emp 3
        // Emp 4
        // Emp 5
        // Emp 6
        // After Last

        public CorporateEnumerator(CorporateCollection<T> collection)
        {
            CurrentIndex = -1;
            CorporateColl = collection;
        }

        //public object Current
        //{
        //    get
        //    {
        //        return CurrentEngineer;
        //    }
        //}
        //T IEnumerator<T>.Current {
        //    get
        //    {
        //        return CurrentEngineer;
        //    }
        //}

        /// <summary>
        /// Current
        /// </summary>
        public object Current => CurrentEngineer;

        /// <summary>
        /// Current Generic
        /// </summary>
        T IEnumerator<T>.Current => CurrentEngineer;

        /// <summary>
        /// MoveNext
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (++CurrentIndex >= CorporateColl.Count())
                return false;
            else
                CurrentEngineer = CorporateColl[CurrentIndex];
            return true;
        }

        /// <summary>
        /// Reset
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="v"></param>
        public void Dispose(bool v)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            _disposed = true;
        }
    }

}

///=========================================================================================================================================//
///=========================================================================================================================================//
///============================================================== NON-GENERIC ==============================================================//
///=========================================================================================================================================//
///=========================================================================================================================================//

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpDotNet.CollectionTopic
//{
//    class TestIEnumerableInterfaceWithGenerics
//    {
//        static void TestForEachWithList()
//        {
//            EngineerModel eng1 = new EngineerModel() { ID = 101, Name = "Jack", Skill = ".NET", IsActive = true };
//            EngineerModel eng2 = new EngineerModel() { ID = 102, Name = "Monty", Skill = "JAVA", IsActive = true };
//            EngineerModel eng3 = new EngineerModel() { ID = 103, Name = "Paul", Skill = "Cloud Computing", IsActive = true };
//            EngineerModel eng4 = new EngineerModel() { ID = 104, Name = "Kelie", Skill = "Azure", IsActive = true };
//            EngineerModel eng5 = new EngineerModel() { ID = 105, Name = "Brian", Skill = "JavaScript", IsActive = true };
//            EngineerModel eng6 = new EngineerModel() { ID = 106, Name = "Aldrin", Skill = "UI UX", IsActive = true };

//            List<EngineerModel> employeeList = new List<EngineerModel>() { eng1, eng2, eng3, eng4, eng4, eng5, eng6 };

//            Console.WriteLine("TestForEachWithList \n");
//            foreach (var emp in employeeList)
//                Console.WriteLine($"ID: {emp.ID} ====> Name: {emp.Name} ====> Skill: {emp.Skill} ====> IsActive: {emp.IsActive}");

//            Console.WriteLine();
//        }

//        static void TestForEachWithUserDefinedGenericCollection()
//        {
//            EngineerModel eng1 = new EngineerModel() { ID = 101, Name = "Jack", Skill = ".NET", IsActive = true };
//            EngineerModel eng2 = new EngineerModel() { ID = 102, Name = "Monty", Skill = "JAVA", IsActive = true };
//            EngineerModel eng3 = new EngineerModel() { ID = 103, Name = "Paul", Skill = "Cloud Computing", IsActive = true };
//            EngineerModel eng4 = new EngineerModel() { ID = 104, Name = "Kelie", Skill = "Azure", IsActive = true };
//            EngineerModel eng5 = new EngineerModel() { ID = 105, Name = "Brian", Skill = "JavaScript", IsActive = true };
//            EngineerModel eng6 = new EngineerModel() { ID = 106, Name = "Aldrin", Skill = "UI UX", IsActive = true };

//            CorporateCollection corporateColl = new CorporateCollection();

//            corporateColl.Add(eng1);
//            corporateColl.Add(eng2);
//            corporateColl.Add(eng3);
//            corporateColl.Add(eng4);
//            corporateColl.Add(eng5);
//            corporateColl.Add(eng6);

//            //List<EngineerModel> employeeList = new List<EngineerModel>() { eng1, eng2, eng3, eng4, eng4, eng5, eng6 };

//            Console.WriteLine("TestForEachWithList \n");
//            foreach (EngineerModel corporate in corporateColl)
//                Console.WriteLine($"ID: {corporate.ID} ====> Name: {corporate.Name} ====> Skill: {corporate.Skill} ====> IsActive: {corporate.IsActive}");

//            Console.WriteLine();
//        }

//        static void Main()
//        {
//            TestForEachWithList();
//            Console.WriteLine("============================================================================");
//            TestForEachWithUserDefinedGenericCollection();
//            Console.ReadLine();
//        }
//    }

//    class EngineerModel
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Skill { get; set; }
//        public bool IsActive { get; set; }
//    }


//    class CorporateCollection : IEnumerable
//    {
//        List<EngineerModel> corporateCollections = null;

//        public CorporateCollection()
//        {
//            corporateCollections = new List<EngineerModel>();
//        }

//        public void Add(EngineerModel engineer)
//        {
//            corporateCollections.Add(engineer);
//        }

//        /// <summary>
//        /// Approach - 1 
//        /// </summary>
//        /// <returns></returns>
//        //public IEnumerator GetEnumerator()
//        //{
//        //    return corporateCollections.GetEnumerator();
//        //}

//        public IEnumerator GetEnumerator()
//        {
//            return new CorporateEnumerator(this);
//        }

//        public int Count()
//        {
//            return corporateCollections.Count;
//        }

//        public EngineerModel this[int index]
//        {
//            get
//            {
//                return corporateCollections[index];
//            }
//        }
//    }

//    class CorporateEnumerator : IEnumerator
//    {
//        CorporateCollection CorporateColl;
//        EngineerModel CurrentEngineer;
//        int CurrentIndex;

//        // Before First <===
//        // Emp 1
//        // Emp 2
//        // Emp 3
//        // Emp 4
//        // Emp 5
//        // Emp 6
//        // After Last

//        public CorporateEnumerator(CorporateCollection collection)
//        {
//            CurrentIndex = -1;
//            CorporateColl = collection;
//        }

//        public object Current
//        {
//            get
//            {
//                return CurrentEngineer;
//            }
//        }

//        public bool MoveNext()
//        {
//            if (++CurrentIndex >= CorporateColl.Count())
//                return false;
//            else
//                CurrentEngineer = CorporateColl[CurrentIndex];
//            return true;
//        }

//        public void Reset()
//        {
//            throw new NotImplementedException();
//        }
//    }

//}
