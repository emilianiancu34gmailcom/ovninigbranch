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
            for(int i=0;i<numbers.Length;i++)
            {
                IsEven(numbers[i]);
            }

        }
    }
}
