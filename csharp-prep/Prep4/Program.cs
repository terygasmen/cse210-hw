using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create list
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // keep asking until 0
        while (number != 0){
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            // add number if not 0
            if (number != 0){
                numbers.Add(number);
            }
        }

        // compute sum
        int sum = 0;
        foreach (int num in numbers) {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // compute average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // find max number
        int max = numbers[0];
        foreach (int num in numbers) {
            if (num > max) {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}