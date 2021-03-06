using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DesignPattern.SingletonPattern
{
    /// <summary>
    /// Thread Safety Singleton
    /// -- sealed class
    /// -- one private static instance
    /// -- ctor private
    /// -- one public static getInstance property
    /// -- LockInstance new object instance and lock in getInstance method
    /// </summary>
    sealed class Singleton2
    {
        private static readonly object LockInstance = new object();
        private static Singleton2 instance = null;
        private Singleton2()
        {

        }

        public static Singleton2 GetInstance
        {
            get
            {
                lock (LockInstance)
                {
                    if(instance == null)
                    {
                        instance = new Singleton2();
                    }
                    return instance;
                }
            }
        }
    }
}
