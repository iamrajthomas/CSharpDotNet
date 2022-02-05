using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.EnumTopic
{
    class TestEnum
    {
        static void TestPreDefinedEnums()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello World");
            Console.BackgroundColor = ConsoleColor.Black;

        }

        static void TestUserDefinedEnum() 
        {
            Days day0 = 0;
            // Days day1 = 1; //Error: Only for index 0, can be written like this. For the next value onwards conversion is required.
            Days day1 = (Days)1;
            Days day7 = (Days)7;
            Console.WriteLine("Day0: " + day0);
            Console.WriteLine("Day1: " + day1);
            Days workingDay = Days.Friday;
            Console.WriteLine("WorkingDay: " + workingDay);
            Console.WriteLine("Integer Representation of value WorkingDay: " + (int)workingDay);
            Console.WriteLine("day7: " + day7); //Prints the number 7, since Days Enum doesn't have any value at index 8
        }
        static void TestUserDefinedEnumWithFistIndex()
        {
            DaysWithFistIndex day1 = (DaysWithFistIndex)1;
            Console.WriteLine("Day1: " + day1);
            DaysWithFistIndex day2 = (DaysWithFistIndex)2;
            Console.WriteLine("Day2: " + day2);
            DaysWithFistIndex day7 = (DaysWithFistIndex)7;
            Console.WriteLine("day7: " + day7); //Prints the number 7, since days doesn't have any value at index 8

            DaysWithFistIndex workingDay = DaysWithFistIndex.Friday;
            Console.WriteLine("WorkingDay: " + workingDay);
            Console.WriteLine("Integer Representation of value WorkingDay: " + (int)workingDay);
        }
        static void TestUserDefinedEnumWithAllDifferentIndex()
        {
            DaysWithAllDifferentIndex day1 = (DaysWithAllDifferentIndex)1;
            Console.WriteLine("Day1: " + day1);
            DaysWithAllDifferentIndex day2 = (DaysWithAllDifferentIndex)2;
            Console.WriteLine("Day2: " + day2);
            DaysWithAllDifferentIndex day7 = (DaysWithAllDifferentIndex)7;
            Console.WriteLine("day7: " + day7); //Prints the number 7, since days doesn't have any value at index 8

            DaysWithAllDifferentIndex workingDay = DaysWithAllDifferentIndex.Friday;
            Console.WriteLine("WorkingDay: " + workingDay);
            Console.WriteLine("Integer Representation of value WorkingDay: " + (int)workingDay);
        }

        static void PrintDaysEnums()
        {
            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.Write(i + " ");
            Console.WriteLine();
            foreach (string s in Enum.GetNames(typeof(Days)))
                Console.Write(s + " ");
            Console.WriteLine();
            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.Write(i + ": " + (Days)i + "   ");
            Console.WriteLine();
        }

        static void PrintDaysWithFistIndexEnums()
        {
            foreach (int i in Enum.GetValues(typeof(DaysWithFistIndex)))
                Console.Write(i + " ");
            Console.WriteLine();
            foreach (string s in Enum.GetNames(typeof(DaysWithFistIndex)))
                Console.Write(s + " ");
            Console.WriteLine();
            foreach (int i in Enum.GetValues(typeof(DaysWithFistIndex)))
                Console.Write(i + ": " + (DaysWithFistIndex)i + "   ");
            Console.WriteLine();
        }

        static void PrintDaysWithAllDifferentIndexEnums()
        {
            foreach (int i in Enum.GetValues(typeof(DaysWithAllDifferentIndex)))
                Console.Write(i + " ");
            Console.WriteLine();
            foreach (string s in Enum.GetNames(typeof(DaysWithAllDifferentIndex)))
                Console.Write(s + " ");
            Console.WriteLine();
            foreach (int i in Enum.GetValues(typeof(DaysWithAllDifferentIndex)))
                Console.Write(i + ": " + (DaysWithAllDifferentIndex)i + "   ");
            Console.WriteLine();
        }

        static void DaysWithLongType() 
        {
            //foreach (int i in Enum.GetValues(typeof(DaysWithLongType)))
            //    Console.Write(i + " "); //Compile Time Error
            foreach (byte i in Enum.GetValues(typeof(DaysWithByteType)))
                Console.Write(i + " ");
            Console.WriteLine();
            foreach (string s in Enum.GetNames(typeof(DaysWithByteType)))
                Console.Write(s + " ");
            Console.WriteLine();
            //foreach (int i in Enum.GetValues(typeof(DaysWithLongType)))
            //    Console.Write(i + ": " + (DaysWithLongType)i + "   "); //Compile Time Error
            foreach (byte i in Enum.GetValues(typeof(DaysWithByteType)))
                Console.Write(i + ": " + (DaysWithByteType)i + "   "); 
            Console.WriteLine();
        }

        static void Main()
        {
            Console.WriteLine("===================================== TestPreDefinedEnums =====================================");
            TestPreDefinedEnums();
            Console.WriteLine();

            Console.WriteLine("===================================== TestUserDefinedEnum =====================================");
            TestUserDefinedEnum();
            Console.WriteLine();

            Console.WriteLine("===================================== TestUserDefinedEnumWithFistIndex =====================================");
            TestUserDefinedEnumWithFistIndex();
            Console.WriteLine();

            Console.WriteLine("===================================== TestUserDefinedEnumWithAllDifferentIndex =====================================");
            TestUserDefinedEnumWithAllDifferentIndex();
            Console.WriteLine();

            Console.WriteLine("===================================== PrintDaysEnums =====================================");
            PrintDaysEnums();
            Console.WriteLine();

            Console.WriteLine("===================================== PrintDaysWithFistIndexEnums =====================================");
            PrintDaysWithFistIndexEnums();
            Console.WriteLine();

            Console.WriteLine("===================================== PrintDaysWithAllDifferentIndexEnums =====================================");
            PrintDaysWithAllDifferentIndexEnums();
            Console.WriteLine();

            Console.WriteLine("===================================== DaysWithLongType =====================================");
            DaysWithLongType();
            Console.WriteLine();

            Console.WriteLine("=====================================");
            Console.ReadLine();
        }
    }

    enum Days
    {
        // List of only working days
        // Index value by deafult starts with 0 in Enum
        Monday, Tuesday, Wednesday, Thursday, Friday

        // Index value by starts from 1 here and sequence follows
        // Monday = 1, Tuesday, Wednesday, Thursday, Friday

        // Index values different for all the days 
        // Monday = 1, Tuesday = 11, Wednesday = 21, Thursday = 31, Friday = 41
    }

    enum DaysWithFistIndex
    {
        // List of only working days
        // Index value by starts from 1 here and sequence follows
        Monday = 1, Tuesday, Wednesday, Thursday, Friday
    }

    enum DaysWithAllDifferentIndex
    {
        // List of only working days
        // Index values different for all the days 
        Monday = 1, Tuesday = 11, Wednesday = 21, Thursday = 31, Friday = 41
    }

    enum DaysWithByteType : byte
    {
        // List of only working days
        // Index value by deafult starts with 0 in Enum
        Monday, Tuesday, Wednesday, Thursday, Friday

        // Index value by starts from 1 here and sequence follows
        // Monday = 1, Tuesday, Wednesday, Thursday, Friday

        // Index values different for all the days 
        // Monday = 1, Tuesday = 11, Wednesday = 21, Thursday = 31, Friday = 41
    }
}
