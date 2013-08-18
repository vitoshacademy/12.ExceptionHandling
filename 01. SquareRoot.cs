// Write a program that reads an integer number and calculates and prints its square root. 
// If the number is invalid or negative, print "Invalid number". 
// In all cases finally print "Good bye". Use try-catch-finally.


using System;
class SquareRoot
{
    private static double GetSQRT(double number)
    {
        if (number < 0)
        {
            throw new System.ArithmeticException();
        }
        return Math.Sqrt(number);
    }
    static void Main()
    {
        Console.WriteLine("The program reads an integer number and\n" +
            "calculates and prints its square root.");
        Console.Write("Please enter an integer number: ");
        try
        {
            int n = int.Parse(Console.ReadLine());
            double result = GetSQRT(n);
            Console.Write("Good job! The number is eligible! The square root is:");
            Console.WriteLine("{0:F10}", result);
        }
        catch (System.FormatException) // Catches exception if the input is not a number
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.OverflowException) // Catches exception if the input out of integer scope
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.ArgumentNullException) // Catches exception if the input is null
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.ArithmeticException) // Catches exception if the input is negative integer
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}
