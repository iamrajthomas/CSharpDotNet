using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.CollectionTopic
{
    class TestIComparableAndIComparerInterfaces
    {
        static void TestStudentModelWithIComparable()
        {
            StudentModel s1 = new StudentModel() { Sid = 701, Name = "Joe", Class = 10, Marks = 557.00f };
            StudentModel s2 = new StudentModel() { Sid = 552, Name = "Marvin", Class = 9, Marks = 471.00f };
            StudentModel s3 = new StudentModel() { Sid = 123, Name = "Nazarenus", Class = 8, Marks = 651.00f };
            StudentModel s4 = new StudentModel() { Sid = 784, Name = "Braden", Class = 7, Marks = 499.00f };
            StudentModel s5 = new StudentModel() { Sid = 125, Name = "Olsson", Class = 6, Marks = 355.00f };

            List<StudentModel> studentList = new List<StudentModel>() { s1, s2, s3, s4, s5 };

            studentList.Sort(); // sorting is made based on Sid, defined in CompareStudentModel with help if IComparable
            studentList.Reverse();

            foreach (StudentModel student in studentList)
                Console.WriteLine($"Sid: {student.Sid} ====> Name: {student.Name} ====> Class: {student.Class} ====> Marks: {student.Marks} ");
        }

        static void TestStudentModelWithIComparer()
        {
            StudentModel s1 = new StudentModel() { Sid = 701, Name = "Joe", Class = 10, Marks = 557.00f };
            StudentModel s2 = new StudentModel() { Sid = 552, Name = "Marvin", Class = 9, Marks = 471.00f };
            StudentModel s3 = new StudentModel() { Sid = 123, Name = "Nazarenus", Class = 8, Marks = 651.00f };
            StudentModel s4 = new StudentModel() { Sid = 784, Name = "Braden", Class = 7, Marks = 499.00f };
            StudentModel s5 = new StudentModel() { Sid = 125, Name = "Olsson", Class = 6, Marks = 355.00f };

            List<StudentModel> studentList = new List<StudentModel>() { s1, s2, s3, s4, s5 };

            CompareStudentModel compareStudentModel = new CompareStudentModel();

            studentList.Sort(compareStudentModel); // sorting is made based on Marks, defined in CompareStudentModel with help if IComparer
            //studentList.Reverse(); // This won't work though, since reverse doens't have any overload taking IComparer<T> as parameter

            foreach (StudentModel student in studentList)
                Console.WriteLine($"Sid: {student.Sid} ====> Name: {student.Name} ====> Class: {student.Class} ====> Marks: {student.Marks} ");
        }

        static void TestStudentModelWithIComparisonDelegate()
        {
            // Here we will sort the studentList by making use of a delegate called Comparision from System namespace
            // Sort method has four overloads. One of the overloads takes Comparision delegate as a parameter
            // Signature of Comparision Delegate is: public delegate int Comparison<in T>(T x, T y);
            // We can define a sort method keeping the same signature as this delegate and bind it
            // Create an instance of delegate and pass the object to sort. The sorting will be done.

            Comparison<StudentModel> comparisonDelegate = new Comparison<StudentModel>(CompareStudentNames); // craeted delegat instance and bound method.

            StudentModel s1 = new StudentModel() { Sid = 701, Name = "Joe", Class = 10, Marks = 557.00f };
            StudentModel s2 = new StudentModel() { Sid = 552, Name = "Marvin", Class = 9, Marks = 471.00f };
            StudentModel s3 = new StudentModel() { Sid = 123, Name = "Nazarenus", Class = 8, Marks = 651.00f };
            StudentModel s4 = new StudentModel() { Sid = 784, Name = "Braden", Class = 7, Marks = 499.00f };
            StudentModel s5 = new StudentModel() { Sid = 125, Name = "Olsson", Class = 6, Marks = 355.00f };

            List<StudentModel> studentList = new List<StudentModel>() { s1, s2, s3, s4, s5 };

            CompareStudentModel compareStudentModel = new CompareStudentModel();

            // Approach - 1
            // passed comparisonDelegate instance and sorting is made based on Name, defined in CompareStudentNames() with help of Comparison delegate

            studentList.Sort(comparisonDelegate);
            // ======================================================================================================================================

            // Approach - 2
            // directly passed CompareStudentNames() method as parameter
            // But in this case, one delegate is internally created and bound to this method for us 
            // And sorting is made based on Name, defined in CompareStudentNames() with help of Comparison delegate

            //studentList.Sort(CompareStudentNames);
            // ======================================================================================================================================

            // Approach - 3
            // Simplified from the top using Anonymous method
            // But in this case also, one delegate is internally created and bound to this method for us 
            // And sorting is made based on Name, defined in CompareStudentNames() with help of Comparison delegate

            //studentList.Sort(delegate(StudentModel x, StudentModel y) { return x.Name.CompareTo(y.Name);  });
            // ======================================================================================================================================

            // Approach - 4
            // Simplified from the top using Anonymous method + Lamda Expression
            // But in this case also, one delegate is internally created and bound to this method for us 
            // And sorting is made based on Name, defined in CompareStudentNames() with help of Comparison delegate

            //studentList.Sort((StudentModel x, StudentModel y) => x.Name.CompareTo(y.Name));
            // ======================================================================================================================================

            //studentList.Reverse(); 

            foreach (StudentModel student in studentList)
                Console.WriteLine($"Sid: {student.Sid} ====> Name: {student.Name} ====> Class: {student.Class} ====> Marks: {student.Marks} ");
        }


        /// This method matches the signature of Comparision Delegate 
        /// public delegate int Comparison<in T>(T x, T y);
        /// kept this method static, so that can call this method with class name, can keep non-static also. No problem with that.
        public static int CompareStudentNames(StudentModel x, StudentModel y)
        {
            return x.Name.CompareTo(y.Name);
        }

        static void Main()
        {

            TestStudentModelWithIComparable();
            Console.WriteLine("===========================================================================================");

            TestStudentModelWithIComparer();
            Console.WriteLine("===========================================================================================");

            TestStudentModelWithIComparisonDelegate();
            Console.WriteLine("===========================================================================================");

            Console.ReadLine();
        }
    }

    class StudentModel : IComparable<StudentModel>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        // Here I want to sort the student model with Sid
        // CompareTo is from IComparable and returns int value
        public int CompareTo(StudentModel other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }

    class CompareStudentModel : IComparer<StudentModel>
    {
        // Here I want to sort the student model with a different property other than what is available in StudentModel > CompareTo() method
        // Compare is from IComparer and returns int value
        public int Compare(StudentModel x, StudentModel y)
        {
            if (x.Sid > y.Sid)
                return 1;
            else if (x.Sid < y.Sid)
                return -1;
            else
                return 0;
        }
    }

}
