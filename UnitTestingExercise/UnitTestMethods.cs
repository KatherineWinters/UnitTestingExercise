using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public object Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public object Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }
        // Create a Multiply method that passes 2 integers
        public object Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // Create a Divide method that passes 2 integers
        public object Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public bool IsOdd(int num)
        {
            if (num % 3 == 0)
                return true;
            else
                return false;
        }

        public bool IsGreaterThanA(int a, int b)
        {
            if (a < b)
                return true;
            else
                return false;
        }
    }
}
