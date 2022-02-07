using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DesignPattern.SingletonPattern
{
    /// <summary>
    /// Thread Safety Singleton using Double-Check Locking
    /// -- sealed class
    /// -- one private static instance
    /// -- ctor private
    /// -- one public static getInstance property
    /// -- LockInstance new object instance and lock in getInstance method
    /// -- double instance null check
    /// </summary>
    sealed class Singleton3
    {
        private static readonly object Lock = new object();
        private static Singleton3 Instance = null;
        private Singleton3()
        {

        }

        public static Singleton3 GetInstance
        {
            get
            {
                if(Instance == null)
                {
                    lock (Lock)
                    {
                        if(Instance == null)
                        {
                            Instance = new Singleton3();
                        }
                    }
                }
                return Instance;
            }
        }
    }
}
