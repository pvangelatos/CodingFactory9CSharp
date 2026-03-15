using System.Text;

namespace MethodChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Checks if a int is even

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        // Calculates the max between of two ints
        public static int Max(int a, int b)
        {
            //return a > b ? a : b;
            return Math.Max(a, b);
        }

        // Calculates the area of a circle
        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Converts Celsius to Fahrenheit f = (c * 9/5) + 32
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // returns repeated string n times
        public static string RepeatString(string str, int n)
        {
            StringBuilder sb = new();       // C# 9.0 new()
            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }

        // Creates a random pin of 4 digits
        public static string GeneratePin()
        {
            Random random = new();
            
            return random.Next(1000, 10000).ToString(); // Generates a number between 1000 and 9999
        }

        // Filtering even numbers from an array
        public static int[] FilterEven(int[] arr)
        {
            // return arr.Where(x => x % 2 == 0).ToArray();
            return [.. arr.Where(x => x % 2 == 0)]; // spread C# 12.0
        }

        // Bubble sort an array of integers
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n -1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);    // tuple swap
                    }
                }
            }
        }

        // Binary search for an int in a sorted array
        public static int BinarySearch(int[] arr, int val)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int med = (left + right) / 2;

                if (arr[med] == val) return med; //found
                
                if (arr[med] < val)
                {
                    left = med + 1; // search right half
                }
                else
                {
                    right = med - 1; // search left half
                }
            }
            return -1;
        }

        // Check if two strings are anagrams
        public static bool IsAnagrams (string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            char[] chars1 = str1.ToUpper().ToCharArray();
            char[] chars2 = str2.ToUpper().ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return new string(chars1) == new string(chars2);
        }

        // Calculate common elements between two arrays
        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            HashSet<int> set1 = [.. arr1];
            HashSet<int> set2 = [.. arr2];

            set1.IntersectWith(set2);
            return [.. set1];


        }

    }
}
