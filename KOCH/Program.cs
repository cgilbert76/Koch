using System;

namespace KOCH
{
    /// <summary>
    /// KOCH interview console program
    /// Author: Colin Gilbert
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var intConverter = new SafeIntConverter();
            
            Console.WriteLine("Enter a string to convert to an integer: ");
            var input = Console.ReadLine();

            //Part 1
            Console.WriteLine($"Converting {input} to an integer using {nameof(SafeIntConverter)} class method");
            intConverter.ToSafeInt(input);

            //Part 2
            Console.WriteLine($"Converting {input} to an integer using ToSafeInt extension method (default value 89 used)");
            input?.ToString().ToSafeInt(89);
        }
    }
}
