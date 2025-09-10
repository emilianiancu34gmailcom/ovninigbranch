using System.Runtime.ExceptionServices;

namespace ovninigbranch
{
    internal class Program
    {
        static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int[] numbers=new int [5];

            //reding numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //testing the numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsEven(numbers[i]) == true)
                    Console.WriteLine("it's even");
                else Console.WriteLine("it's not even");
            }
        }
    }
}
