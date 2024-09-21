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

        // smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers) {
            if (num > 0 && num < smallestPositive) {
                smallestPositive = num;
            }
        }
        if (smallestPositive != int.MaxValue) {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        } else {
            Console.WriteLine("There are no positive numbers.");
        }
        
        // sort list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers) {
            Console.WriteLine(num);
        }
    }
}