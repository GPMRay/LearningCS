using System;

namespace Arrays_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5]; // Declared and initialized an array called 'grades' with five values.

            // The number inside the square is referred to as the index number. Always starts with 0.
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("Grades at index 0: {0}", grades[0]);

            int input = Convert.ToInt32(Console.ReadLine());
            // Assign value to array grades at index 0.
            grades[0] = input;
            Console.WriteLine("Grades at index 0: {0}", grades[0]);

            // Another way of initializing an array.
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // Third way of initializing an array.
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            // Wrote the length of gradesOfMathStudentsA array by using the .Length property.
            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
        }
    }
}
