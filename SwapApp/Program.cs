using System.Runtime.Intrinsics.Arm;

namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(a, b);
            Console.WriteLine($"a: {a}, b: {b}"); // Output: a: 1, b: 2
        }

        /// <summary>
        /// Pass by value - does not swap the values of a and b in the caller method.
        /// </summary>
        /// <param name="a">the first input num</param>
        /// <param name="b">the second input num</param>
        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// The original variables are modified.
        /// </summary>
        /// <param name="a">the first input num</param>
        /// <param name="b">the second input num</param>
        public static void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static (int, int) SwapWithTuples(int a, int b)
        {
            return (b, a);
        }
    }
}
