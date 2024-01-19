using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Declaring all the variables/lists
        int userNumber = -1;
        List<int> numbers = new List<int>();


        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // finds the sum of the numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // finds the average of the numbers
        float average = (float)sum / numbers.Count;

        // finds the highest number in the list
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The sum is {sum} ");
        Console.WriteLine($"The average is {average} ");
        Console.WriteLine($"The max is: {max}");
    }
}