using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DesignPattern.SingletonPattern
{
    /// <summary>
    /// Using .NET 4's Lazy<T> type
    /// -- sealed class
    /// -- one private static Lazy delegate to invoke ctor
    /// -- ctor private
    /// -- one public static getInstance property
    /// </summary>
    sealed class Singleton5
    {
        // If you are using .NET 4 or higher then you can use the System.Lazy<T> type to make the laziness really simple.
        // You can pass a delegate to the constructor that calls the Singleton constructor, which is done most easily with a lambda expression.
        // Allows you to check whether or not the instance has been created with the IsValueCreated property.
        private static readonly Lazy<Singleton5> lazyInstance = new Lazy<Singleton5>(() => new Singleton5());

        private Singleton5()
        {

        }

		public static Singleton5 GetInstance
        {
			get
            {
                if (lazyInstance.IsValueCreated)
                    Console.WriteLine("lazy.IsValueCreated: " + lazyInstance.IsValueCreated);

                return lazyInstance.Value;
            }
        }
    }
}
