using System;

namespace CSharpDotNet.DelegateTopic
{
    // Step - 1: Define Delegate 
    public delegate void RectangleDelegate(double height, double width); //non-value returning delegate
    public delegate string RectangleDelegate2(double height, double width); //value returning delegate
    class TestMultiCastDelegate
    {
        // Non-value returning methods
        public void GetArea(double height, double width)
        {
            Console.WriteLine("Area of Rectangle = " + (height * width));
        }
        public void GetPerimeter(double height, double width)
        {
            Console.WriteLine("Perimeter of Rectangle = " + 2 * (height + width));
        }

        // Value returning methods
        public string GetAreaValue(double height, double width)
        {
            return "Area of Rectangle = " + (height * width);
        }
        public string GetPerimeterValue(double height, double width)
        {
            return "Perimeter of Rectangle = " + 2 * (height + width);
        }

        public static void PerformMultiCastDelegateRelatedOperationForNonValueReturningMethods()
        {
            TestMultiCastDelegate testMultiCastDelegate = new TestMultiCastDelegate();

            // Step - 2: Instantiate the delegate by passing method as parameter matching its signature
            // Here GetArea() and GetPerimeter() are accessed with the instance of TestMultiCastDelegate since it's a non-static method

            // Instantiate Approach - 1:
            // RectangleDelegate rectangleDelegate = new RectangleDelegate(testMultiCastDelegate.GetArea);
            // Instantiate Approach - 2:
            RectangleDelegate rectangleDelegate = testMultiCastDelegate.GetArea;

            //Binding Multiple Method to one delegate
            rectangleDelegate += testMultiCastDelegate.GetPerimeter;

            rectangleDelegate.Invoke(12.34, 56.78);
            rectangleDelegate(12.34, 56.78);
        }

        public static void PerformMultiCastDelegateRelatedOperationForValueReturningMethods()
        {
            TestMultiCastDelegate testMultiCastDelegate = new TestMultiCastDelegate();

            // Step - 2: Instantiate the delegate by passing method as parameter matching its signature
            // Here GetArea() and GetPerimeter() are accessed with the instance of TestMultiCastDelegate since it's a non-static method

            // Instantiate Approach - 1:
            //RectangleDelegate2 rectangleDelegate2 = new RectangleDelegate2(testMultiCastDelegate.GetAreaValue);
            // Instantiate Approach - 2:
            RectangleDelegate2 rectangleDelegate2 = testMultiCastDelegate.GetAreaValue;

            //Binding Multiple Method to one delegate
            rectangleDelegate2 += testMultiCastDelegate.GetPerimeterValue;

            //Step - 3: Call the delegate by passing required parameter values, so that internally the method which is bound with the delegate gets executed.
            var result = rectangleDelegate2(12.34, 56.78);
            Console.WriteLine(result);

            // Another Approach to call with delegate is with Invoke method
            result = rectangleDelegate2.Invoke(12.34, 56.78);
            Console.WriteLine(result);

            // Note: With Value Returning Method being bound to delegate, only the last method's value gets return. 
            // It is because the return value/ output parameters of first method are overridden by next bound method.
            // Only the last method's return values/ output parameter values are captured by the delegate.
        }

        static void Main()
        {
            PerformMultiCastDelegateRelatedOperationForNonValueReturningMethods();
            Console.WriteLine("======================================================================================");
            PerformMultiCastDelegateRelatedOperationForValueReturningMethods();
            Console.ReadLine();
        }
    }
}
