// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
// a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class Program
{
    static void ReadNumber(int start, int end)
    {
        Console.WriteLine("Please, enter 10 numbers, between 2 and 99 including. The then numbers should be in ascending order, otherwise there would be an exception!");
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            try
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < start || arr[i] > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of input!"); break;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is out of the range!"); break;
            }
        }
    }
    static void Main(string[] args)
    {
        int start = 2;
        int end = 100;
        ReadNumber(start, end);
    }
}
