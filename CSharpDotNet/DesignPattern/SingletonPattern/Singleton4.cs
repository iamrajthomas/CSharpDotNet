using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DesignPattern.SingletonPattern
{
    /// <summary>
    /// Thread Safe Singleton without using locks and no lazy instantiation
    /// -- sealed class
    /// -- one private static instance created, no lazy instantiation
    /// -- ctor private
    /// -- one public static getInstance property
    /// -- LockInstance new object instance and lock in getInstance method
    /// -- static ctor
    /// </summary>
    sealed class Singleton4
    {
        private static readonly object Lock = new object();
        private static Singleton4 Instance = new Singleton4();
        private Singleton4()
        {

        }

        //This type of implementation has a static constructor, so it executes only once per Application Domain.
        //It is not as lazy as the other implementation.
        static Singleton4()
        {

        }

        public static Singleton4 GetInstance
        {
            get
            {
                return Instance;
            }
        }
    }
}
