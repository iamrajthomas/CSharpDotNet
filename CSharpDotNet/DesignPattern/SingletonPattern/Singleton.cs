using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DesignPattern.SingletonPattern
{
    /// <summary>
    /// No Thread Safe Singleton
    /// Singleton Pattern:
    /// -- sealed class
    /// -- one private static instance
    /// -- ctor private
    /// -- one public static getInstance method
    /// </summary>
    sealed class Singleton
    {
        private static Singleton _instance = null;
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}

